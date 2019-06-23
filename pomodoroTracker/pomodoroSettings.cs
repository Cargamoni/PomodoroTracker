using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;

namespace pomodoroTracker
{
    class pomodoroSettings
    {
        public int pomodoroTime;
        public int shortBreakTime;
        public int longBreakTime;
        public int pomodoroCounter;
        public int totalPomodoro;
        public string breakAlarm;
        public string[] importedData;
        public pomodoroSettings()
        {
            pomodoroTime = 25;
            shortBreakTime = 5;
            longBreakTime = 30;
            pomodoroCounter = 1;
            totalPomodoro = 0;
            breakAlarm = "sounds/Alarm01.wav";
        }

        public void exportData(string[] data)
        {
            string xmlTableName = DateTime.Today.ToShortDateString();
            xmlTableName = xmlTableName.Replace("/", ".");


            //         <? xml version = "1.0" standalone = "yes" ?>
            //         < DocumentElement >
            //               < _x0036_.23.2019 >
            //                   < ID > 1 </ ID >
            //                   < First_x0020_Name > First A </ First_x0020_Name >
            //                   < Last_x0020_Name > Last A </ Last_x0020_Name >         
            //                   < Age > 10 </ Age >         
            //               </ _x0036_.23.2019 >
            //        </ DocumentElement >

            //DataTable table = new DataTable(xmlTableName);
            //table.Columns.Add("ID", typeof(int));
            //table.Columns.Add("First Name", typeof(string));
            //table.Columns.Add("Last Name", typeof(string));
            //table.Columns.Add("Age", typeof(int));

            //table.Rows.Add(1, "First A", "Last A", 10);
            //table.Rows.Add(2, "First B", "Last B", 20);
            //table.Rows.Add(3, "First C", "Last C", 30);
            //table.Rows.Add(4, "First D", "Last D", 40);
            //table.Rows.Add(5, "First E", "Last E", 50);
            //table.Rows.Add(6, "First F", "Last F", 60);
            //table.Rows.Add(7, "First G", "Last G", 70);
            //table.Rows.Add(8, "First H", "Last H", 80);
            //table.Rows.Add(9, "First I", "Last I", 90);

            //table.WriteXml("myData.xml", XmlWriteMode.WriteSchema);
            //table.WriteXml("myData.xml");



            //       <? xml version = "1.0" encoding = "utf-8" ?>
            //       < !--6.23.2019 Gününün Bilgileri-->
            //       < elementBurası >
            //           < element2Burası >
            //               < elementStringBurası > buda değeri sanırım</ elementStringBurası >
            //           </ element2Burası >
            //       </ elementBurası >

            //XmlTextWriter xmlWriter = new XmlTextWriter("myData.xml", Encoding.UTF8);
            //xmlWriter.Formatting = Formatting.Indented;

            //xmlWriter.WriteStartDocument();
            //xmlWriter.WriteComment(xmlTableName + " Gününün Bilgileri");

            //xmlWriter.WriteStartElement("elementBurası");

            //xmlWriter.WriteStartElement("element2Burası");                                  //Element Açar
            //xmlWriter.WriteElementString("element2StringBurası", "buda değeri sanırım");    //Element Verisi yazılır
            //xmlWriter.WriteEndElement();

            //xmlWriter.WriteStartElement("element3Burası");
            //xmlWriter.WriteElementString("element3StringBurası", "buda değeri sanırım");

            XmlTextWriter xmlWriter = new XmlTextWriter("myData.xml", Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment(xmlTableName + " Gününün Bilgileri");


            xmlWriter.WriteStartElement("date-" + xmlTableName);                                   

            for (int i = 0; i <= data.Length - 1; i++)
            {

                xmlWriter.WriteStartElement("gunlukVeri");                                  //Element Açar
                //xmlWriter.WriteElementString("id", i.ToString());                                       //Element Verisi yazılır
                xmlWriter.WriteElementString("yapilacak", data[i]);
                xmlWriter.WriteEndElement();                                                            //Element Kapatır
            }

            //xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }

        public void importData(string tarih)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("myData.xml");
            //XmlNodeList nodes = doc.DocumentElement.SelectNodes("date-" + tarih);
            string xmlRoot = "/date-" + tarih + "/gunlukVeri"; //+ "/pomodoro-" + totalPomodoro;
            XmlNodeList nodes = doc.DocumentElement.SelectNodes(xmlRoot);
            int yapilacakCount = 0;
            foreach (XmlNode node in nodes)
            {
                yapilacakCount++;
            }

            importedData = new string[yapilacakCount];
            int i = 0;
            foreach (XmlNode node in nodes)
            {
                importedData[i] = node.SelectSingleNode("yapilacak").InnerXml.ToString();
                i++;
            }
        }
    }
}
