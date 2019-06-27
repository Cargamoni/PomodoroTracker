using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace pomodoroTracker
{
    public partial class pomodoroFrom : Form
    {
        pomodoroSettings ayarlar = new pomodoroSettings();
        SoundPlayer alarmSesi;
        int kalanZaman = 0;
        int durumZaman = 0;
        bool isBreak = false;
        bool isLongBreak = false;
        public pomodoroFrom()
        {
            //ilk açılıştaki varsayılan değerleri girmeyi sağlar.
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            duzenleme();

            DataSet dt = new DataSet();
            dt = ayarlar.newImport();

            if (dt != null)
            {
                foreach (DataColumn column in dt.Tables[0].Columns)
                    dataGridView1.Columns.Add("column1", column.ColumnName);

                ayarlar.newImportedData = new string[dt.Tables[0].Rows.Count, dt.Tables[0].Columns.Count];

                for (int i = 0; i <= dt.Tables[0].Rows.Count - 1; i++)
                {
                    DataGridViewRow testRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                    for (int j = 0; j <= dt.Tables[0].Columns.Count - 1; j++)
                    {
                        testRow.Cells[j].Value = dt.Tables[0].Rows[i][j];
                        ayarlar.newImportedData[i,j] = dt.Tables[0].Rows[i][j].ToString();      //Breakpoint koyulacak.
                    }
                    dataGridView1.Rows.Add(testRow);
                }
            }

            kategoriToImport();
        }

        #region Component Düzenleyen Fonksiyon
        public void duzenleme()
        {
            hizliLabel.Text = "Hızlı Bilgiler : " + ayarlar.pomodoroTime.ToString() + " " + ayarlar.shortBreakTime.ToString() + " " + ayarlar.longBreakTime.ToString() + " " + ayarlar.pomodoroCounter.ToString();
            zamanLabel.Text = ayarlar.pomodoroTime.ToString() + ":00";
            kalanZaman = ayarlar.pomodoroTime * 60;
            durumZaman = kalanZaman;

            //Alarm seslerinin ayarlanması
            //string path = AppDomain.CurrentDomain.BaseDirectory;
            //System.Windows.Forms.MessageBox.Show(path);
            alarmSesi = new SoundPlayer(ayarlar.breakAlarm);
            //alarmSesi.Play();

            int buttonSize = (pomodoroBox.Width / 3) - 4;

            //Buton lokasyon ayarlamaları
            buttonRestart.Width = buttonSize;
            buttonReset.Width = buttonSize;
            buttonStart.Width = buttonSize;
            buttonReset.Location = new Point(buttonStart.Location.X + buttonSize + 2, buttonStart.Location.Y);
            buttonRestart.Location = new Point(buttonReset.Location.X + buttonSize + 2, buttonReset.Location.Y);

            //Gerisayım Yerleştirme
            zamanLabel.Location = new Point(this.Width / 2 - zamanLabel.Width / 2, zamanLabel.Location.Y);

            //Yapilacak ve Yapılmış Yerleştirme
            yapilacakBox.Width = this.Width / 2 - 25;
            yapilmisBox.Width = this.Width / 2 - 25;
            yapilmisBox.Location = new Point(yapilacakBox.Location.X + yapilacakBox.Width + 10, yapilacakBox.Location.Y);

            yapilacakEkle.Width = (int)(yapilacakBox.Width * 0.30) - 10;
            textBox1.Width = (int)(yapilacakBox.Width * 0.70);
            yapilacakEkle.Location = new Point(textBox1.Location.X + textBox1.Width + 2, textBox1.Location.Y);
            yapilmisSil.Width = yapilacakBox.Width - 10;

            yapilacakList.Width = yapilacakBox.Width - 10;
            yapilmisList.Width = yapilmisBox.Width - 10;


            // Combobox İçi Doldurma
            if (comboBox1.Items.Count == 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (i < 10)
                        comboBox1.Items.Add("Alarm0" + i.ToString() + ".wav");
                    else
                        comboBox1.Items.Add("Alarm" + i.ToString() + ".wav");
                }
                comboBox1.SelectedIndex = 0;
            }

            pomodoroReset();
        }
        #endregion
        #region Genel Fonksiyonlar
        //Zamanlayıcı çalışıysa durdurur, çalışmıyorsa başlatır.
        public void timerStarter()
        {

            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else
            {
                if (kalanZaman > 0)
                    timer1.Enabled = true;
            }
        }

        //ProgressBar yüzdesinin ayarlanması.
        public void yapilanYuzde()
        {
            if (yapilmisList.Items.Count != 0 && yapilmisList.Items.Count != 0)
                progressBar1.Value = (yapilmisList.Items.Count * 100) / (yapilacakList.Items.Count + yapilmisList.Items.Count);
            else if (yapilmisList.Items.Count == 0 && yapilmisList.Items.Count == 0)
                progressBar1.Value = 0;

        }

        // O anki ayarlar neyse ona göre kalan zamanı ve pomodoroyu sıfırlar
        public void pomodoroReset()
        {
            ayarlar.pomodoroCounter = 1;
            kalanZaman = ayarlar.pomodoroTime * 60;
            durumZaman = kalanZaman;
            isBreak = false;
            hizliLabel.Text = "Hızlı Bilgiler : " + ayarlar.pomodoroTime.ToString() + " " + ayarlar.shortBreakTime.ToString() + " " + ayarlar.longBreakTime.ToString() + " " + ayarlar.pomodoroCounter.ToString();
            zamanLabel.Text = ayarlar.pomodoroTime.ToString() + ":00";
            timer1.Stop();
        }

        //Pomodoro'nun Durumlarına göre sürede ayarlamaları yapar.
        public void trackPomodoro()
        {
            //Uzun aradan sonra pomodoro sıfırlar.
            if (isLongBreak)
            {
                pomodoroReset();
                isLongBreak = !isLongBreak;
                alarmSesi.Play();
                //MessageBox.Show(ayarlar.totalPomodoro.ToString() + ". Uzun aran bitti hadi bakalım iş başına !", "Çalışma Zamanı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (isBreak && ayarlar.pomodoroCounter < 4)              // Eğer aradaysa ve 4. pomodoroda değilse tracker'ı break'a ayarlar
            {
                kalanZaman = ayarlar.shortBreakTime * 60;
                durumZaman = kalanZaman;
                alarmSesi.Play();
                //MessageBox.Show(ayarlar.pomodoroCounter.ToString() + ". Pomodoro bitti kısa mola zamanı (:", "Ara Zamanı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ayarlar.pomodoroCounter++;

                timerStarter();
            }
            else if (isBreak && ayarlar.pomodoroCounter >= 4)       //Eğer uzun aradaysa pomodroyu 1. pomodoroya çeker ve uzun ara
            {
                kalanZaman = ayarlar.longBreakTime * 60;
                durumZaman = kalanZaman;
                ayarlar.pomodoroCounter = 1;
                ayarlar.totalPomodoro++;
                alarmSesi.Play();
                //MessageBox.Show(ayarlar.totalPomodoro.ToString() + ". Tam Pomodoro bitti uzun bir arayı hakettin !", "Ara Zamanı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isLongBreak = !isLongBreak;

                timerStarter();

            }
            else                                                   //Çalışma süresi belirlenir ve aradan çıkmayı sağlar.
            {
                kalanZaman = ayarlar.pomodoroTime * 60;
                durumZaman = kalanZaman;
                isBreak = false;
                alarmSesi.Play();
                //MessageBox.Show("Ara bitti üzgünüm ama çalışmaya devam !", "Çalışma Zamanı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                timerStarter();
            }
            zamanLabel.Text = kalanZaman / 60 + ":" + ((kalanZaman % 60) >= 10 ? (kalanZaman % 60).ToString() : "0" + (kalanZaman % 60));
            hizliLabel.Text = "Hızlı Bilgiler : " + ayarlar.pomodoroTime.ToString() + " " + ayarlar.shortBreakTime.ToString() + " " + ayarlar.longBreakTime.ToString() + " " + ayarlar.pomodoroCounter.ToString();
        }

        //Yapılacak ve yapılmış işleri diziye aktarır.
        public void dataToExport()
        {
            if (yapilmisList.Items.Count != 0)
            {
                if (yapilacakList.Items.Count != 0)
                {
                    int rowsCount = yapilacakList.Items.Count + yapilmisList.Items.Count;
                    string[,] exportData = new string[rowsCount, 3];
                    for (int i = 0; i <= yapilacakList.Items.Count - 1; i++)
                    {
                        for (int j = 0; j <= 2; j++)
                        {
                            if (j == 0)
                                exportData[i, j] = yapilacakList.Items[i].ToString().Split('|')[1].TrimEnd().TrimStart();
                            else if (j == 1)
                                exportData[i, j] = "false";
                            else
                                exportData[i, j] = yapilacakList.Items[i].ToString().Split('|')[0].TrimEnd();
                        }
                    }
                    int fark = yapilacakList.Items.Count;
                    for (int i = 0; i <= yapilmisList.Items.Count - 1; i++)
                    {
                        for (int j = 0; j <= 2; j++)
                        {
                            if (j == 0)
                                exportData[i +fark, j] = yapilmisList.Items[i].ToString().Split('|')[1].TrimEnd().TrimStart();
                            else if (j == 1)
                                exportData[i + fark, j] = "true";
                            else
                                exportData[i + fark, j] = yapilmisList.Items[i].ToString().Split('|')[0].TrimEnd();
                        }
                    }
                    ayarlar.newExportedData = exportData;
                    ayarlar.newExport();
                }
            }
        }


        //Yeni Import Yöntemi ile listeleri yükleme
        public bool arrayToImport()
        {
            ayarlar.newImport();
            if (ayarlar.newImportedData != null && ayarlar.newImportedData.Length != 0)
            {
                if (ayarlar.newImportedData.Length != 0)
                {
                    string[,] data = ayarlar.newImportedData;
                    for (int i = 0; i <= ayarlar.newImportedData.GetUpperBound(0); i++)
                    {
                            if (data[i, 1] == "false")
                                yapilacakList.Items.Add(data[i, 2].ToString() + " | " + data[i, 0]);
                            else
                                yapilmisList.Items.Add(data[i, 2].ToString() + " | " + data[i, 0]);
                    }
                }
                yapilanYuzde();
                return true;
            }
            else
                return false;

        }

        public void kategoriToImport()
        {
            DataSet dt = new DataSet();
            dt = ayarlar.kategoriImport();
            if (dt != null)
            {
                kategoriComboBox2.Items.Clear();
                ayarlar.kategori = new string[dt.Tables[0].Rows.Count];
                for (int i = 0; i <= dt.Tables[0].Rows.Count - 1; i++)
                {
                    kategoriComboBox2.Items.Add(dt.Tables[0].Rows[i][0].ToString());
                    ayarlar.kategori[i] = dt.Tables[0].Rows[i][0].ToString();
                }
                kategoriComboBox2.SelectedIndex = 0;
                kategoriComboBox2.Enabled = true;
            }
            else
            {
                kategoriComboBox2.Enabled = false;
            }
        }

        public void kategoriToExport(string sonKategori)
        {
            string[] newKategori = new string[ayarlar.kategori.Length + 1];
            for (int i = 0; i <= newKategori.Length - 1; i++)
            {
                if (i == newKategori.Length - 1)
                    newKategori[i] = sonKategori;
                else
                    newKategori[i] = ayarlar.kategori[i];
            }
            ayarlar.kategori = newKategori;
            ayarlar.kategoriExport();
        }

        public bool pipeController(string gelenText)
        {
            for (int i = 0; i <= gelenText.Length - 1; i++)
            {
                if (gelenText[i] == '|')
                    return false;
            }
            return true;            
        }

        #endregion
        #region Evenets ButtonClick
        //Butona basıldığında zmaan başlatır veya durdurur.
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerStarter();
        }

        //O anki zamanı sıfırlar.
        private void buttonReset_Click(object sender, EventArgs e)
        {
            kalanZaman = durumZaman;
            zamanLabel.Text = kalanZaman / 60 + ":" + ((kalanZaman % 60) >= 10 ? (kalanZaman % 60).ToString() : "0" + (kalanZaman % 60));
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tüm pomodoroyu resetler (total pomodoro değişmez)
            pomodoroReset();
        }

        //Yapılacaklar Listesine Eleman Ekler
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (pipeController(textBox1.Text))
                {
                    yapilacakList.Items.Add(textBox1.Text + " | " + kategoriComboBox2.SelectedItem.ToString());
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Pipe karakteri kategorileri birbirinden ayırmak için kullanıldığından bu alanda kullanamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
            }
            yapilanYuzde();
        }

        //Yapılmışlar listesini temizler
        private void button2_Click(object sender, EventArgs e)
        {
            yapilmisList.Items.Clear();
            yapilanYuzde();
        }

        //Ayarları pomodoroSettings'e kaydeder ve arayüzü güncelleyerek sıfırlar.
        private void button1_Click_2(object sender, EventArgs e)
        {
            ayarlar.pomodoroTime = Convert.ToInt32(textBox2.Text);
            ayarlar.shortBreakTime = Convert.ToInt32(textBox3.Text);
            ayarlar.longBreakTime = Convert.ToInt32(textBox4.Text);
            ayarlar.pomodoroCounter = Convert.ToInt32(textBox5.Text);

            if (ayarlar.operatingSystem == "Windows")
                ayarlar.breakAlarm = @"sounds\" + comboBox1.SelectedItem.ToString();
            else
                ayarlar.breakAlarm = "sounds/" + comboBox1.SelectedItem.ToString();

            pomodoroReset();
            duzenleme();
        }

        //Combobox üzerinde seçili olan sesi çalar.
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (ayarlar.operatingSystem == "Windows")
                alarmSesi = new SoundPlayer(@"sounds\" + comboBox1.SelectedItem.ToString());
            else
               alarmSesi = new SoundPlayer("sounds/" + comboBox1.SelectedItem.ToString());
            alarmSesi.Play();
        }
        #endregion
        #region EventHandlers
        //Zamanın her saniyesinin darbesini ile kalan zamanın değişmesi, ekrandaki sürenin azalmasının sağlanması
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Saat çalışma eylemi aynı zamanda break ve trackPomodoro triggerlar
            kalanZaman--;
            zamanLabel.Text = kalanZaman / 60 + ":" + ((kalanZaman % 60) >= 10 ? (kalanZaman % 60).ToString() : "0" + (kalanZaman % 60));
            if (kalanZaman <= 0)
            {
                timer1.Enabled = false;
                isBreak = !isBreak;
                trackPomodoro();
            }
        }

        //Yapılacakalr listesine eklerken Enter tuşunun kullanımı
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox1.Text.Length != 0)
                {
                    if (pipeController(textBox1.Text))
                    {
                        yapilacakList.Items.Add(textBox1.Text + " | " + kategoriComboBox2.SelectedItem.ToString());
                        textBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Pipe karakteri kategorileri birbirinden ayırmak için kullanıldığından bu alanda kullanamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Clear();
                    }
                }
                yapilanYuzde();
            }
        }

        //Yapılacaklar Listesindeki her birime çift tıklayarak yapılmışlara gönderme.
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (yapilacakList.SelectedItem != null)
            {
                yapilmisList.Items.Add(yapilacakList.Items[yapilacakList.SelectedIndex].ToString());
                yapilacakList.Items.Remove(yapilacakList.SelectedItem);
            }
            yapilanYuzde();
        }

        //Yapılmış listesindeki her bir elemana tıklayarak silme.
        private void yapilmisList_DoubleClick(object sender, EventArgs e)
        {
            if (yapilmisList.SelectedItem != null)
            {
                yapilmisList.Items.Remove(yapilmisList.SelectedItem);
            }
            yapilanYuzde();
        }

        //Tab değiştirildiğinde ayarların yüklenmesi, eğer süre çalışıyorsa zamanın durudurulup resetlenmesi
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = ayarlar.pomodoroTime.ToString();
            textBox3.Text = ayarlar.shortBreakTime.ToString();
            textBox4.Text = ayarlar.longBreakTime.ToString();
            textBox5.Text = ayarlar.pomodoroCounter.ToString();
            if (timer1.Enabled && tabControl1.SelectedIndex != 1)
            {
                DialogResult resetleme = MessageBox.Show("Süreniz hala çalışyor, ayarları kaydedip pomodoroyu sıfırlamak ister misiniz ?", "Çalışma Zamanı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resetleme == DialogResult.Yes)
                {
                    ayarlar.pomodoroTime = Convert.ToInt32(textBox2.Text);
                    ayarlar.shortBreakTime = Convert.ToInt32(textBox3.Text);
                    ayarlar.longBreakTime = Convert.ToInt32(textBox4.Text);
                    ayarlar.pomodoroCounter = Convert.ToInt32(textBox5.Text);
                    pomodoroReset();
                    duzenleme();
                }
            }
        }

        //Yapılmış listesinden elemanları yapılacaklara sağ tıklama ile gönderme.
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (yapilmisList.SelectedItem != null)
            {
                yapilacakList.Items.Add(yapilmisList.Items[yapilmisList.SelectedIndex].ToString());
                yapilmisList.Items.Remove(yapilmisList.SelectedItem);
            }
            yapilanYuzde();
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)      //Export Button
        {
            dataToExport();
        }

        private void button4_Click(object sender, EventArgs e)      //Import button
        {
            arrayToImport();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataToExport();
        }

        //Kategori ekleme bölümü
        private void kategoriEkle_Click(object sender, EventArgs e)
        {
            if(kategoriTextBox6.Text.Length != 0)
            {
                kategoriToExport(kategoriTextBox6.Text);
                kategoriToImport();
                kategoriTextBox6.Clear();
            }
        }
    }
}
