using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Tablo_Server
{
    public partial class Form1 : Form
    {
        public static string name1 = "Команда 1", name2 = "Команда 2", time_timer = "", real_times = "", timers = "";//переменные которые хранят всю информацию
        public static int ch1 = 0, ch2 = 0, a = 0;//счет командм
        public static int h = 0, m = 0, s = 0;//переменные для времени
        TimeSpan ts = new TimeSpan(h, m, s);
        public bool live = true;//переменная для проверки

        static IPAddress ipAd = IPAddress.Parse("192.168.56.1");//задаем айпи адрес сервера
        static IPAddress R_UDP = IPAddress.Parse("224.0.0.1");//задаем адрес UDP рассылки

        const int remotePort = 8001;
        const int sendPort = 8008;
        static int PortNumber = 8888;//порт для отправки инфы сервером
        List<TcpClient> listConnectedClients = new List<TcpClient>();//список который хранит подключенных клиентов
        int number_user = -1;

        //string serverResponse = name1 + "*" + name2 + "*" + ch1 + "*" + ch2 + "*" + real_times + "*" + timers;

        public Form1()
        {
            InitializeComponent();
            otchet.Stop();//останавливаем таймер отсчета
            Tablo();
            
        }

        #region Работа по UDP
        private void Send_IP()//отправка IP и порта клиенту
        {
            Action<string> DelegateTeste_ModifyText = THREAD_MOD;//функция вывода в текстбокс

            UdpClient sender = new UdpClient(); // создаем UdpClient для отправки
            IPEndPoint endPoint = new IPEndPoint(R_UDP, sendPort);//создаем конечную точку

            Thread.Sleep(1500);//усыпляем процесс на 1.5с, чтобы клиент успел получить

            string message = "192.168.56.18888"; // сообщение для отправки
            message = String.Format(message);
            byte[] data = Encoding.Unicode.GetBytes(message);//создаем массив байт
            sender.Send(data, data.Length, endPoint); // отправка
            Invoke(DelegateTeste_ModifyText, "Отправил IP");//вывод сообщения в текстбокс, что отправлено IP

        }

        private void Receive_request()//прием запроса от клиента на получение IP и порта
        {
            Action<string> DelegateTeste_ModifyText = THREAD_MOD;
            UdpClient receiver = new UdpClient(remotePort); // UdpClient для получения данных
            receiver.JoinMulticastGroup(R_UDP, 20);//подключаемся к рассылке
            IPEndPoint remoteIp = null;

            while (true)//запускаем бесконечный цикл приема запросов от клиентов
            {
                byte[] data = receiver.Receive(ref remoteIp); // получаем данные
                string message = Encoding.Unicode.GetString(data);
                if(message == "give ip brotherly")//проверка,что пришел запрос
                {
                    Invoke(DelegateTeste_ModifyText, "Получил запрос");//вывод сообщения о пришедшем запросе
                    Send_IP();//вызов функции отправки
                    
                }
                
            }
        }
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            Task s = new Task(Receive_request);//при загрузке формы создаем поток для приема запросов
            s.Start();

        }

        private void THREAD_MOD(string teste)//функция вывода в текстбокс
        {
            txtStatus.Text += Environment.NewLine + teste;
        }

        private void ServerSends()//отправка строки с информацией
        {
            Action<string> DelegateTeste_ModifyText = THREAD_MOD;
            Invoke(DelegateTeste_ModifyText, listConnectedClients[number_user].ToString());
            TcpClient clientSocket = listConnectedClients[number_user];//приравниваем клиента из списка к TcpClient переменной
            try
            {
                while (true)//запускаем цикл для отправки
                {
                    NetworkStream networkStream = clientSocket.GetStream();//открываем поток
                    byte[] bytesFrom = new byte[20];
                    Thread.Sleep(200);//усыпляем ненадолго процесс, чтобы цикл не нагружал ЦП
                    networkStream.Read(bytesFrom, 0, 20);//читаем поток на сообщения от клиента
                    string dataFromClient = Encoding.Unicode.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                    string serverResponse = name1 + "*" + name2 + "*" + ch1 + "*" + ch2 + "*" + real_times + "*" + timers;//заполняем строку данными
                    Byte[] sendBytes = Encoding.Unicode.GetBytes(serverResponse);
                    Thread.Sleep(200);//усыпляем ненадолго процесс, чтобы цикл не нагружал ЦП
                    networkStream.Write(sendBytes, 0, sendBytes.Length);//записываем в поток 
                    networkStream.Flush();
                }
            }
            catch (Exception ex)
            {
                Invoke(DelegateTeste_ModifyText, ex.Message);
            }
        }

        private void StartServer()//старт работы сервера
        {
            try
            {
                Action<string> DelegateTeste_ModifyText = THREAD_MOD;
                TcpListener ServerListener = new TcpListener(IPAddress.Any, PortNumber);//запускаем прослушивание для всех айпи
                ServerListener.Start();

                Invoke(DelegateTeste_ModifyText, "Сервер ожидает подключения!");
                Invoke(DelegateTeste_ModifyText, "Сервер готов!");

                int i = 0;
                while (true)
                {
                    try
                    {
                        TcpClient tcpclient = ServerListener.AcceptTcpClient();//получаем клиента
                        Invoke(DelegateTeste_ModifyText, $"Клиент {i} подключился"); i++;

                        listConnectedClients.Add(tcpclient); number_user++;//вносим его в список

                        Thread clientThread = new Thread(new ThreadStart(ServerSends));//запускаем для него поток по отправке сообщений
                        clientThread.Start();

                    }
                    catch (Exception ex)
                    {
                        Invoke(DelegateTeste_ModifyText, ex.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Трансляция уже запущена!", "Ошибка");
            }

            

        }

        //описание контролов которые взаимодействуют с разными командами
        #region Команда 1

        private void input_team_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                name1 = input_team_1.Text;
                Tablo();
                input_team_1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ch1++;
            Tablo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ch1 += 5;
            Tablo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ch1 = 0;
            Tablo();
        }

        private void input_check_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string j = input_check_1.Text;
                ch1 = int.Parse(j);
                Tablo();
                input_check_1.Clear();
            }
        }

        private void input_check_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)//цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Команда 2
        private void input_team_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                name2 = input_team_2.Text;
                Tablo();
                input_team_2.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ch2++;
            Tablo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ch2 += 5;
            Tablo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ch2 = 0;
            Tablo();
        }

        private void input_check_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string j = input_check_2.Text;
                ch2 = int.Parse(j);
                Tablo();
                input_check_2.Clear();
            }
        }

        
        private void input_check_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        #endregion

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//при закрытии формы, закрываются все потоки
        {
            Environment.Exit(1);
        }

        private void input_minutes_KeyDown(object sender, KeyEventArgs e)//функция задания времени для таймера в минутах, при нажатии Enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                string j = input_minutes.Text;
                a = int.Parse(j);
                if (a >= 60)
                {
                    h = a / 60; m = a % 60;
                }
                else
                {
                    h = 0; m = a;
                }
                ts = TimeSpan.Zero;
                ts = ts.Subtract(new TimeSpan(-h, -m, -s));
                input_minutes.Clear();
            }
        }

        private void input_minutes_KeyPress(object sender, KeyPressEventArgs e)//запрет на ввод символов, кроме цифр и BackSpace
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)//цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        public void Tablo()//функция присваивания контролам значения переменных
        {
            name_team_1.Text = name1; name_team_2.Text = name2;
            check_team_1.Text = ch1.ToString(); check_team_2.Text = ch2.ToString();
            
        }

        private void button7_Click(object sender, EventArgs e)//включение трансляции
        {
            Thread s = new Thread(new ThreadStart(StartServer));//запускаем поток
            s.Start();
            otchet.Start();//запускаем таймер обратного отсчета

            button7.Visible = false;
            button8.FlatAppearance.BorderColor = Color.Red;
            button8.Visible = true;

        }

        private void button8_Click(object sender, EventArgs e)//выключение трансляции
        {
            if (live == true)
            {
                otchet.Stop();//останавливаем таймер обратного отсчета
                live = false;
                button8.Text = "Включить таймер"; button8.FlatAppearance.BorderColor = Color.Green; timers = "пауза";
            }
            else
            {
                live = true; otchet.Start(); button8.Text = "Остановить таймер"; button8.FlatAppearance.BorderColor = Color.Red;
            }
        }

        private void otchet_Tick(object sender, EventArgs e)
        {
            if (ts == TimeSpan.Zero)
            {
                timers = "Конец"; label6.Text = "Конец";
            }
            else
            {

                timers = ts.ToString();
                label6.Text = ts.ToString();
                ts = ts.Subtract(new TimeSpan(0, 0, 1));
            }
            

        }

        

        private void time_Tick(object sender, EventArgs e)//реальное время
        {
            real_times = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            real_time.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();

        }
    }
}
