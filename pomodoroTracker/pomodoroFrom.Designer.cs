﻿namespace pomodoroTracker
{
    partial class pomodoroFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pomodoroBox = new System.Windows.Forms.GroupBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.zamanLabel = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.hizliLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.yapilmisBox = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.yapilacakBox = new System.Windows.Forms.GroupBox();
            this.yapilacakEkle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.yapilacakList = new System.Windows.Forms.ListBox();
            this.yapilmisList = new System.Windows.Forms.ListBox();
            this.yapilmisSil = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pomodoroBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.yapilmisBox.SuspendLayout();
            this.yapilacakBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pomodoroBox
            // 
            this.pomodoroBox.Controls.Add(this.buttonRestart);
            this.pomodoroBox.Controls.Add(this.zamanLabel);
            this.pomodoroBox.Controls.Add(this.buttonReset);
            this.pomodoroBox.Controls.Add(this.buttonStart);
            this.pomodoroBox.Controls.Add(this.hizliLabel);
            this.pomodoroBox.Location = new System.Drawing.Point(4, 5);
            this.pomodoroBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pomodoroBox.Name = "pomodoroBox";
            this.pomodoroBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pomodoroBox.Size = new System.Drawing.Size(1068, 278);
            this.pomodoroBox.TabIndex = 0;
            this.pomodoroBox.TabStop = false;
            this.pomodoroBox.Text = "Pomodoro Timer";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(403, 233);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(186, 35);
            this.buttonRestart.TabIndex = 4;
            this.buttonRestart.Text = "Pomodoro Sıfırla";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.button1_Click);
            // 
            // zamanLabel
            // 
            this.zamanLabel.AutoSize = true;
            this.zamanLabel.Font = new System.Drawing.Font("Ebrima", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zamanLabel.Location = new System.Drawing.Point(8, 84);
            this.zamanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zamanLabel.Name = "zamanLabel";
            this.zamanLabel.Size = new System.Drawing.Size(394, 86);
            this.zamanLabel.TabIndex = 3;
            this.zamanLabel.Text = "zamanLabel";
            this.zamanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(224, 233);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(171, 35);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Zamanı Sıfırla";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(4, 233);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(212, 35);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Başlat/Durdur";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // hizliLabel
            // 
            this.hizliLabel.AutoSize = true;
            this.hizliLabel.Location = new System.Drawing.Point(24, 42);
            this.hizliLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hizliLabel.Name = "hizliLabel";
            this.hizliLabel.Size = new System.Drawing.Size(74, 20);
            this.hizliLabel.TabIndex = 0;
            this.hizliLabel.Text = "hizliLabel";
            this.toolTip1.SetToolTip(this.hizliLabel, "Rakamlar sırasıyla Pomodoro Zamanını, Kısa Arayı, Uzun Arayı, Kaçıncı Pomodoro\'da" +
        " olduğunuzu belirtir.");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 795);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.yapilmisBox);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.yapilacakBox);
            this.tabPage1.Controls.Add(this.pomodoroBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1076, 762);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pomodoro Tracker";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // yapilmisBox
            // 
            this.yapilmisBox.Controls.Add(this.yapilmisSil);
            this.yapilmisBox.Controls.Add(this.yapilmisList);
            this.yapilmisBox.Location = new System.Drawing.Point(467, 322);
            this.yapilmisBox.Name = "yapilmisBox";
            this.yapilmisBox.Size = new System.Drawing.Size(453, 432);
            this.yapilmisBox.TabIndex = 3;
            this.yapilmisBox.TabStop = false;
            this.yapilmisBox.Text = "Yapılmışlar";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 292);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1068, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // yapilacakBox
            // 
            this.yapilacakBox.Controls.Add(this.yapilacakList);
            this.yapilacakBox.Controls.Add(this.yapilacakEkle);
            this.yapilacakBox.Controls.Add(this.textBox1);
            this.yapilacakBox.Location = new System.Drawing.Point(8, 322);
            this.yapilacakBox.Name = "yapilacakBox";
            this.yapilacakBox.Size = new System.Drawing.Size(453, 432);
            this.yapilacakBox.TabIndex = 1;
            this.yapilacakBox.TabStop = false;
            this.yapilacakBox.Text = "Yapılacaklar";
            // 
            // yapilacakEkle
            // 
            this.yapilacakEkle.Location = new System.Drawing.Point(300, 391);
            this.yapilacakEkle.Name = "yapilacakEkle";
            this.yapilacakEkle.Size = new System.Drawing.Size(147, 35);
            this.yapilacakEkle.TabIndex = 1;
            this.yapilacakEkle.Text = "Ekle";
            this.yapilacakEkle.UseVisualStyleBackColor = true;
            this.yapilacakEkle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1076, 762);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ayarlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yapilacakList
            // 
            this.yapilacakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yapilacakList.FormattingEnabled = true;
            this.yapilacakList.ItemHeight = 24;
            this.yapilacakList.Location = new System.Drawing.Point(6, 25);
            this.yapilacakList.Name = "yapilacakList";
            this.yapilacakList.Size = new System.Drawing.Size(441, 364);
            this.yapilacakList.TabIndex = 2;
            this.yapilacakList.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // yapilmisList
            // 
            this.yapilmisList.ContextMenuStrip = this.contextMenuStrip1;
            this.yapilmisList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yapilmisList.FormattingEnabled = true;
            this.yapilmisList.ItemHeight = 24;
            this.yapilmisList.Location = new System.Drawing.Point(6, 25);
            this.yapilmisList.Name = "yapilmisList";
            this.yapilmisList.Size = new System.Drawing.Size(441, 364);
            this.yapilmisList.TabIndex = 3;
            this.yapilmisList.DoubleClick += new System.EventHandler(this.yapilmisList_DoubleClick);
            // 
            // yapilmisSil
            // 
            this.yapilmisSil.Location = new System.Drawing.Point(6, 391);
            this.yapilmisSil.Name = "yapilmisSil";
            this.yapilmisSil.Size = new System.Drawing.Size(441, 35);
            this.yapilmisSil.TabIndex = 3;
            this.yapilmisSil.Text = "Listeyi Temizle";
            this.yapilmisSil.UseVisualStyleBackColor = true;
            this.yapilmisSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(338, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(438, 26);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pomodoro Zamanını Dakika Cinsinden Giriniz - Varsayılan: 25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kısa Ara Zamanını Dakika Cinsinden Giriniz - Varsayılan: 5";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(338, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(438, 26);
            this.textBox3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uzun Ara Zamanını Dakika Cinsinden Giriniz - Varsayılan: 30";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(338, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(438, 26);
            this.textBox4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kaçıncı Pomodoro\'da Olduğunuzu Değiştirin";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(338, 234);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(438, 26);
            this.textBox5.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ayarları Kaydet ve Sıfırla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Seçili Alarmı Çal ve Ayarla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(338, 296);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(438, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Alarm Sesini Seçin";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Yapılacaklara Taşı";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1076, 762);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Çalışma Verilerim";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "Yapılacakları Dışa Aktar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 35);
            this.button4.TabIndex = 1;
            this.button4.Text = "Yapılacakları İçe Aktar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(414, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "(Deneme Sürümünde Sadece Günlük Verileri Geri Getirir)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1084, 797);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pomodoroBox.ResumeLayout(false);
            this.pomodoroBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.yapilmisBox.ResumeLayout(false);
            this.yapilacakBox.ResumeLayout(false);
            this.yapilacakBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pomodoroBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label hizliLabel;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label zamanLabel;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox yapilacakBox;
        private System.Windows.Forms.Button yapilacakEkle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox yapilmisBox;
        private System.Windows.Forms.ListBox yapilmisList;
        private System.Windows.Forms.ListBox yapilacakList;
        private System.Windows.Forms.Button yapilmisSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
    }
}
