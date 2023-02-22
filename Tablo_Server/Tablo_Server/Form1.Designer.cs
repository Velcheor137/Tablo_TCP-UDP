namespace Tablo_Server
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.input_team_1 = new System.Windows.Forms.TextBox();
            this.input_team_2 = new System.Windows.Forms.TextBox();
            this.name_team_1 = new System.Windows.Forms.Label();
            this.name_team_2 = new System.Windows.Forms.Label();
            this.check_team_1 = new System.Windows.Forms.Label();
            this.check_team_2 = new System.Windows.Forms.Label();
            this.real_time = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.input_check_1 = new System.Windows.Forms.TextBox();
            this.input_check_2 = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.input_minutes = new System.Windows.Forms.TextBox();
            this.otchet = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Sends = new System.Windows.Forms.Timer(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input_team_1
            // 
            this.input_team_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_team_1.Location = new System.Drawing.Point(55, 79);
            this.input_team_1.Name = "input_team_1";
            this.input_team_1.Size = new System.Drawing.Size(162, 20);
            this.input_team_1.TabIndex = 0;
            this.input_team_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_team_1_KeyDown);
            // 
            // input_team_2
            // 
            this.input_team_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_team_2.Location = new System.Drawing.Point(575, 78);
            this.input_team_2.Name = "input_team_2";
            this.input_team_2.Size = new System.Drawing.Size(162, 20);
            this.input_team_2.TabIndex = 1;
            this.input_team_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_team_2_KeyDown);
            // 
            // name_team_1
            // 
            this.name_team_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_team_1.AutoSize = true;
            this.name_team_1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_team_1.ForeColor = System.Drawing.Color.Indigo;
            this.name_team_1.Location = new System.Drawing.Point(50, 35);
            this.name_team_1.Name = "name_team_1";
            this.name_team_1.Size = new System.Drawing.Size(67, 27);
            this.name_team_1.TabIndex = 2;
            this.name_team_1.Text = "label1";
            // 
            // name_team_2
            // 
            this.name_team_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_team_2.AutoSize = true;
            this.name_team_2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_team_2.ForeColor = System.Drawing.Color.Indigo;
            this.name_team_2.Location = new System.Drawing.Point(570, 35);
            this.name_team_2.Name = "name_team_2";
            this.name_team_2.Size = new System.Drawing.Size(67, 27);
            this.name_team_2.TabIndex = 3;
            this.name_team_2.Text = "label2";
            this.name_team_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // check_team_1
            // 
            this.check_team_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_team_1.AutoSize = true;
            this.check_team_1.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_team_1.ForeColor = System.Drawing.Color.DarkOrange;
            this.check_team_1.Location = new System.Drawing.Point(48, 133);
            this.check_team_1.Name = "check_team_1";
            this.check_team_1.Size = new System.Drawing.Size(116, 135);
            this.check_team_1.TabIndex = 4;
            this.check_team_1.Text = "0";
            // 
            // check_team_2
            // 
            this.check_team_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_team_2.AutoSize = true;
            this.check_team_2.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_team_2.ForeColor = System.Drawing.Color.DarkOrange;
            this.check_team_2.Location = new System.Drawing.Point(574, 133);
            this.check_team_2.Name = "check_team_2";
            this.check_team_2.Size = new System.Drawing.Size(116, 135);
            this.check_team_2.TabIndex = 5;
            this.check_team_2.Text = "0";
            // 
            // real_time
            // 
            this.real_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.real_time.AutoSize = true;
            this.real_time.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.real_time.ForeColor = System.Drawing.Color.DarkBlue;
            this.real_time.Location = new System.Drawing.Point(355, 9);
            this.real_time.Name = "real_time";
            this.real_time.Size = new System.Drawing.Size(94, 38);
            this.real_time.TabIndex = 6;
            this.real_time.Text = "время";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(325, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 45);
            this.label6.TabIndex = 7;
            this.label6.Text = "00:00:00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(55, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "+1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(111, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "+5";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(167, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "сброс";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(575, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 45);
            this.button4.TabIndex = 13;
            this.button4.Text = "сброс";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(631, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 45);
            this.button5.TabIndex = 12;
            this.button5.Text = "+5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(687, 298);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 45);
            this.button6.TabIndex = 11;
            this.button6.Text = "+1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // input_check_1
            // 
            this.input_check_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_check_1.Location = new System.Drawing.Point(55, 367);
            this.input_check_1.Name = "input_check_1";
            this.input_check_1.Size = new System.Drawing.Size(106, 20);
            this.input_check_1.TabIndex = 14;
            this.input_check_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_check_1_KeyDown);
            this.input_check_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_check_1_KeyPress);
            // 
            // input_check_2
            // 
            this.input_check_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_check_2.Location = new System.Drawing.Point(631, 367);
            this.input_check_2.Name = "input_check_2";
            this.input_check_2.Size = new System.Drawing.Size(106, 20);
            this.input_check_2.TabIndex = 15;
            this.input_check_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_check_2_KeyDown);
            this.input_check_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_check_2_KeyPress);
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.Location = new System.Drawing.Point(345, 358);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 29);
            this.button7.TabIndex = 16;
            this.button7.Text = "Начало эфира";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(345, 393);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 36);
            this.button8.TabIndex = 17;
            this.button8.Text = "Остановить таймер";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // input_minutes
            // 
            this.input_minutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_minutes.Location = new System.Drawing.Point(345, 298);
            this.input_minutes.Name = "input_minutes";
            this.input_minutes.Size = new System.Drawing.Size(125, 20);
            this.input_minutes.TabIndex = 18;
            this.input_minutes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_minutes_KeyDown);
            this.input_minutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_minutes_KeyPress);
            // 
            // otchet
            // 
            this.otchet.Enabled = true;
            this.otchet.Interval = 1000;
            this.otchet.Tick += new System.EventHandler(this.otchet_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Пусто";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatus.Location = new System.Drawing.Point(310, 78);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(183, 134);
            this.txtStatus.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_minutes);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.input_check_2);
            this.Controls.Add(this.input_check_1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.real_time);
            this.Controls.Add(this.check_team_2);
            this.Controls.Add(this.check_team_1);
            this.Controls.Add(this.name_team_2);
            this.Controls.Add(this.name_team_1);
            this.Controls.Add(this.input_team_2);
            this.Controls.Add(this.input_team_1);
            this.Name = "Form1";
            this.Text = "Табло-сервер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_team_1;
        private System.Windows.Forms.TextBox input_team_2;
        private System.Windows.Forms.Label name_team_1;
        private System.Windows.Forms.Label name_team_2;
        private System.Windows.Forms.Label check_team_1;
        private System.Windows.Forms.Label check_team_2;
        private System.Windows.Forms.Label real_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox input_check_1;
        private System.Windows.Forms.TextBox input_check_2;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox input_minutes;
        private System.Windows.Forms.Timer otchet;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Sends;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

