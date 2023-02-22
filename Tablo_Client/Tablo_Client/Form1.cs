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
using System.IO;

namespace Tablo_Client
{
    public partial class Form1 : Form
    {
        public static string name1 = "Команда 1", name2 = "Команда 2", real_times = "", time_timer = "";//переменные для хранении информации
        public static string ch1 = "0", ch2 = "0";


        TcpClient tcpclnt = new TcpClient();
        static string ip = "*";//переменная для IP
        int PortNumber = 0;//переменная для порта
        static IPAddress R_UDP = IPAddress.Parse("224.0.0.1");//IP для UDP рассылки
        const int localPort = 8001;
        const int recPort = 8008;
        bool s = true;
        static NetworkStream serverStream;
        int i = 1;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sends.Stop();//оставливаем таймер присванивания контролам информации
            timer1.Start();//фановая фигня, которая меняет фон с котиками

        }

        private void Sends_Tick(object sender, EventArgs e)//функция таймера, каждые 100млс присваивает значения контролам
        {
            name_team_1.Text = name1; name_team_2.Text = name2;
            check_team_1.Text = ch1; check_team_2.Text = ch2;
            real_time.Text = real_times; otchet_time.Text = time_timer;
        }




        private void ReceiveMsg()//функция получения IP и порта сервера
        {
            Action<string> DelegateTeste_ModifyText = THREAD_MOD;

            UdpClient receiver = new UdpClient(recPort); // UdpClient для получения данных
            receiver.JoinMulticastGroup(R_UDP, 1);//подключаемся к широковещательной рассылки
            IPEndPoint remoteIp = null;
            string message = "";
            bool app = true;//проверочная переменная
            while (app)
            {
                byte[] data = receiver.Receive(ref remoteIp); // получаем данные
                message = Encoding.Unicode.GetString(data);//присваиваем их
 
                if (message.Substring(0, 3) == "192")//проверка, что это сообщения с локальным IP адресом
                {
                    ip = message.Substring(0, 12);//сначала берем первые 12 символов
                    PortNumber = int.Parse(message.Substring(12));//тут берем символы после 12 символа
                    Invoke(DelegateTeste_ModifyText, $"Получил IP: {ip}:{PortNumber}");//вывод, что получили IP и порт
                    app = false;//присваиваем ложь, чтобы цикл закрылся
                }
            }
 

        }


        private void Send_request()//функция отправки запроса на получения IP и порта сервера
        {
            Action<string> DelegateTeste_ModifyText = THREAD_MOD;
            UdpClient sender = new UdpClient(); // создаем UdpClient для отправки
            IPEndPoint endPoint = new IPEndPoint(R_UDP, localPort);//создаем точку

            string message = "give ip brotherly"; // сообщение для отправки
            message = String.Format(message);
            byte[] data = Encoding.Unicode.GetBytes(message);
            sender.Send(data, data.Length, endPoint); // отправка
            Invoke(DelegateTeste_ModifyText, "Отправил запрос");
            sender.Close();//закрываем 
            ReceiveMsg();//вызываем функцию принятия 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Thread send_UDP = new Thread(new ThreadStart(Send_request));//создаем и запускаем поток
            send_UDP.Start();
            button2.Visible = false;
            Thread.Sleep(1000);//усыпляем процесс, чтобы кнопка появлялась чуть медленнее 
            button1.Visible = true;
            
            label1.Text = "IP received";
            label1.ForeColor = Color.Green;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//функция при закрытии формы, закрываем все потоки
        {
            Environment.Exit(1);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            i = rnd.Next(1, 10);
            switch (i)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._6;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._7;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._8;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._9;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._10;
                    break;
            }
        }


        private void StartClient()
        {

            while (true)
            {
                serverStream = tcpclnt.GetStream();
                String str = "." + "$";

                byte[] ba = Encoding.Unicode.GetBytes(str);
                //Thread.Sleep(200);
                serverStream.Write(ba, 0, ba.Length);

                byte[] bb = new byte[100];
                //Thread.Sleep(200);
                int k = serverStream.Read(bb, 0, 100);
                string inf = Encoding.Unicode.GetString(bb);
                var res = inf.Split(new[] { '*' }, 6);
                name1 = res[0]; name2 = res[1]; ch1 = res[2]; ch2 = res[3]; real_times = res[4]; time_timer = res[5];
                //serverStream.Close();
            }

        }

        private void THREAD_MOD(string teste)//вывод в текстбокс
        {
            tex.Text += Environment.NewLine + teste;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                button1.Visible = false;
                Sends.Start();//запускаем функцию присваивания контролам
                tcpclnt.Connect(IPAddress.Parse(ip), PortNumber);//присоединяемся к серверу
                tex.Text += Environment.NewLine + "Подключено";


                Thread ThreadingClient = new Thread(new ThreadStart(StartClient));//запускаем поток
                ThreadingClient.Start();
            }
            catch//если в try ошибка, выводим это
            {
                button1.Visible = true;
                MessageBox.Show("Соединения нет!", "Ошибка");
            }
        }      

    }
}
