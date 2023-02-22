namespace Tablo_Client
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
            this.real_time = new System.Windows.Forms.Label();
            this.otchet_time = new System.Windows.Forms.Label();
            this.check_team_1 = new System.Windows.Forms.Label();
            this.check_team_2 = new System.Windows.Forms.Label();
            this.name_team_1 = new System.Windows.Forms.Label();
            this.name_team_2 = new System.Windows.Forms.Label();
            this.Sends = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // real_time
            // 
            this.real_time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.real_time.AutoSize = true;
            this.real_time.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.real_time.ForeColor = System.Drawing.Color.DarkBlue;
            this.real_time.Location = new System.Drawing.Point(289, 425);
            this.real_time.Name = "real_time";
            this.real_time.Size = new System.Drawing.Size(97, 38);
            this.real_time.TabIndex = 0;
            this.real_time.Text = "Время";
            // 
            // otchet_time
            // 
            this.otchet_time.AutoSize = true;
            this.otchet_time.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.otchet_time.ForeColor = System.Drawing.Color.DarkRed;
            this.otchet_time.Location = new System.Drawing.Point(258, 179);
            this.otchet_time.Name = "otchet_time";
            this.otchet_time.Size = new System.Drawing.Size(171, 55);
            this.otchet_time.TabIndex = 1;
            this.otchet_time.Text = "Таймер";
            // 
            // check_team_1
            // 
            this.check_team_1.AutoSize = true;
            this.check_team_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_team_1.Cursor = System.Windows.Forms.Cursors.No;
            this.check_team_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.check_team_1.Font = new System.Drawing.Font("Comic Sans MS", 65F, System.Drawing.FontStyle.Bold);
            this.check_team_1.ForeColor = System.Drawing.Color.DarkOrange;
            this.check_team_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.check_team_1.Location = new System.Drawing.Point(71, 137);
            this.check_team_1.Name = "check_team_1";
            this.check_team_1.Size = new System.Drawing.Size(105, 122);
            this.check_team_1.TabIndex = 3;
            this.check_team_1.Text = "0";
            this.check_team_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // check_team_2
            // 
            this.check_team_2.AutoSize = true;
            this.check_team_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_team_2.Cursor = System.Windows.Forms.Cursors.No;
            this.check_team_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.check_team_2.Font = new System.Drawing.Font("Comic Sans MS", 65F, System.Drawing.FontStyle.Bold);
            this.check_team_2.ForeColor = System.Drawing.Color.DarkOrange;
            this.check_team_2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.check_team_2.Location = new System.Drawing.Point(504, 137);
            this.check_team_2.Name = "check_team_2";
            this.check_team_2.Size = new System.Drawing.Size(105, 122);
            this.check_team_2.TabIndex = 4;
            this.check_team_2.Text = "0";
            this.check_team_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name_team_1
            // 
            this.name_team_1.AutoSize = true;
            this.name_team_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_team_1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_team_1.ForeColor = System.Drawing.Color.Indigo;
            this.name_team_1.Location = new System.Drawing.Point(71, 95);
            this.name_team_1.Name = "name_team_1";
            this.name_team_1.Size = new System.Drawing.Size(95, 29);
            this.name_team_1.TabIndex = 5;
            this.name_team_1.Text = "Команда";
            // 
            // name_team_2
            // 
            this.name_team_2.AutoSize = true;
            this.name_team_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_team_2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_team_2.ForeColor = System.Drawing.Color.Indigo;
            this.name_team_2.Location = new System.Drawing.Point(504, 95);
            this.name_team_2.Name = "name_team_2";
            this.name_team_2.Size = new System.Drawing.Size(95, 29);
            this.name_team_2.TabIndex = 6;
            this.name_team_2.Text = "Команда";
            // 
            // Sends
            // 
            this.Sends.Enabled = true;
            this.Sends.Tick += new System.EventHandler(this.Sends_Tick);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(286, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Подключение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Получить IP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tex
            // 
            this.tex.Location = new System.Drawing.Point(12, 334);
            this.tex.Multiline = true;
            this.tex.Name = "tex";
            this.tex.Size = new System.Drawing.Size(180, 123);
            this.tex.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(551, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "No IP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Tablo_Client.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(693, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(693, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tex);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_team_2);
            this.Controls.Add(this.name_team_1);
            this.Controls.Add(this.check_team_2);
            this.Controls.Add(this.check_team_1);
            this.Controls.Add(this.otchet_time);
            this.Controls.Add(this.real_time);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Табло";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label real_time;
        private System.Windows.Forms.Label otchet_time;
        private System.Windows.Forms.Label check_team_1;
        private System.Windows.Forms.Label check_team_2;
        private System.Windows.Forms.Label name_team_1;
        private System.Windows.Forms.Label name_team_2;
        private System.Windows.Forms.Timer Sends;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

