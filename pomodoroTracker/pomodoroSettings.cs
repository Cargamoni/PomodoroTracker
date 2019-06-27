using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.IO;
using System.Xml.Linq;

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
        public string[,] newImportedData;
        public string[,] newExportedData;
        public string[] kategori;
        public string operatingSystem;
        public pomodoroSettings()
        {
            pomodoroTime = 25;
            shortBreakTime = 5;
            longBreakTime = 30;
            pomodoroCounter = 1;
            totalPomodoro = 0;
            OperatingSystem osName = System.Environment.OSVersion;
            operatingSystem = osName.VersionString.Split(' ')[0];
            if (operatingSystem == "Windows")
                breakAlarm = @"sounds\Alarm01.wav";
            else
                breakAlarm = "sounds/Alarm01.wav";
            System.GC.SuppressFinalize(osName);
        }

        #region Old Export
        //public void exportData(string[] data)
        //{
        //    string xmlTableName = DateTime.Today.ToShortDateString();
        //    xmlTableName = xmlTableName.Replace("/", ".");


        //    //         <? xml version = "1.0" standalone = "yes" ?>
        //    //         < DocumentElement >
        //    //               < _x0036_.23.2019 >
        //    //                   < ID > 1 </ ID >
        //    //                   < First_x0020_Name > First A </ First_x0020_Name >
        //    //                   < Last_x0020_Name > Last A </ Last_x0020_Name >         
        //    //                   < Age > 10 </ Age >         
        //    //               </ _x0036_.23.2019 >
        //    //        </ DocumentElement >

        //    //DataTable table = new DataTable(xmlTableName);
        //    //table.Columns.Add("ID", typeof(int));
        //    //table.Columns.Add("First Name", typeof(string));
        //    //table.Columns.Add("Last Name", typeof(string));
        //    //table.Columns.Add("Age", typeof(int));

        //    //table.Rows.Add(1, "First A", "Last A", 10);
        //    //table.Rows.Add(2, "First B", "Last B", 20);
        //    //table.Rows.Add(3, "First C", "Last C", 30);
        //    //table.Rows.Add(4, "First D", "Last D", 40);
        //    //table.Rows.Add(5, "First E", "Last E", 50);
        //    //table.Rows.Add(6, "First F", "Last F", 60);
        //    //table.Rows.Add(7, "First G", "Last G", 70);
        //    //table.Rows.Add(8, "First H", "Last H", 80);
        //    //table.Rows.Add(9, "First I", "Last I", 90);

        //    //table.WriteXml("myData.xml", XmlWriteMode.WriteSchema);
        //    //table.WriteXml("myData.xml");



        //    //       <? xml version = "1.0" encoding = "utf-8" ?>
        //    //       < !--6.23.2019 Gününün Bilgileri-->
        //    //       < elementBurası >
        //    //           < element2Burası >
        //    //               < elementStringBurası > buda değeri sanırım</ elementStringBurası >
        //    //           </ element2Burası >
        //    //       </ elementBurası >

        //    //XmlTextWriter xmlWriter = new XmlTextWriter("myData.xml", Encoding.UTF8);
        //    //xmlWriter.Formatting = Formatting.Indented;

        //    //xmlWriter.WriteStartDocument();
        //    //xmlWriter.WriteComment(xmlTableName + " Gününün Bilgileri");

        //    //xmlWriter.WriteStartElement("elementBurası");

        //    //xmlWriter.WriteStartElement("element2Burası");                                  //Element Açar
        //    //xmlWriter.WriteElementString("element2StringBurası", "buda değeri sanırım");    //Element Verisi yazılır
        //    //xmlWriter.WriteEndElement();

        //    //xmlWriter.WriteStartElement("element3Burası");
        //    //xmlWriter.WriteElementString("element3StringBurası", "buda değeri sanırım");

        //    XmlTextWriter xmlWriter = new XmlTextWriter("myData.xml", Encoding.UTF8);
        //    xmlWriter.Formatting = Formatting.Indented;
        //    xmlWriter.WriteStartDocument();
        //    xmlWriter.WriteComment(xmlTableName + " Gününün Bilgileri");


        //    xmlWriter.WriteStartElement("date-" + xmlTableName);                                   

        //    for (int i = 0; i <= data.Length - 1; i++)
        //    {

        //        xmlWriter.WriteStartElement("gunlukVeri");                                  //Element Açar
        //        //xmlWriter.WriteElementString("id", i.ToString());                                       //Element Verisi yazılır
        //        xmlWriter.WriteElementString("yapilacak", data[i]);
        //        xmlWriter.WriteEndElement();                                                            //Element Kapatır
        //    }

        //    //xmlWriter.WriteEndElement();
        //    xmlWriter.WriteEndDocument();
        //    xmlWriter.Flush();
        //    xmlWriter.Close();
        //}
        #endregion
        #region Old Import
        //public void importData()
        //{
        //    string xmlTableName = DateTime.Today.ToShortDateString();
        //    xmlTableName = xmlTableName.Replace("/", ".");
        //    if (File.Exists("data-" + xmlTableName + ".xml"))
        //    {
        //        XmlDocument doc = new XmlDocument();
        //        doc.Load("data-" + xmlTableName + ".xml");
        //        //XmlNodeList nodes = doc.DocumentElement.SelectNodes("date-" + tarih);
        //        string xmlRoot = "/date-" + xmlTableName + "/gunlukVeri"; //+ "/pomodoro-" + totalPomodoro;
        //        XmlNodeList nodes = doc.DocumentElement.SelectNodes(xmlRoot);
        //        int yapilacakCount = 0;
        //        foreach (XmlNode node in nodes)
        //        {
        //            yapilacakCount++;
        //        }

        //        importedData = new string[yapilacakCount];
        //        int i = 0;
        //        foreach (XmlNode node in nodes)
        //        {
        //            importedData[i] = node.SelectSingleNode("yapilacak").InnerXml.ToString();
        //            i++;
        //        }
        //    }
        //    else
        //        System.Windows.Forms.MessageBox.Show("Bugüne ait içe aktarılacak veri bulunamadı.","Veri Bulunamadı !", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        //}
        #endregion
        #region Different Data Func Old
        //public bool differentData()
        //{
        //    int difNumber = 0;
        //    this.importData();
        //    for (int i = 0; i <= exportedData.Length - 1; i++)
        //    {
        //        for (int j = 0; j <= importedData.Length - 1; j++)
        //        {
        //            if (importedData[j] == exportedData[i])
        //                break;
        //            else if (importedData[j] != exportedData[i] && j == importedData.Length - 1)
        //                difNumber++;
        //        }
        //    }

        //    if (difNumber != 0)
        //    {
        //        dataDifference = new string[difNumber];
        //        int k = 0;
        //        for (int i = 0; i <= exportedData.Length - 1; i++)
        //        {
        //            for (int j = 0; j <= importedData.Length - 1; j++)
        //            {
        //                if (importedData[j] == exportedData[i])
        //                    break;
        //                else if (importedData[j] != exportedData[i] && j == importedData.Length - 1)
        //                {
        //                    dataDifference[k] = exportedData[i];
        //                    k++;
        //                }
        //            }
        //        }
        //        return true;
        //    }
        //    return false;
        //}
        #endregion
        #region adoptExportData
        //public void adoptExportData(string tarih, string[] data)
        //{ 
        //    string xmlTableName = DateTime.Today.ToShortDateString();
        //    xmlTableName = xmlTableName.Replace("/", ".");

        //    if (!File.Exists("data-" + xmlTableName + ".xml"))
        //    {
        //        XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
        //        xmlWriterSettings.Indent = true;
        //        xmlWriterSettings.NewLineOnAttributes = true;
        //        using (XmlWriter xmlWriter = XmlWriter.Create("data-" + xmlTableName + ".xml", xmlWriterSettings))
        //        {
        //            xmlWriter.WriteStartDocument();
        //            xmlWriter.WriteComment(xmlTableName + " Gününün Bilgileri");

        //            xmlWriter.WriteStartElement("date-" + xmlTableName);

        //            for (int i = 0; i <= data.Length - 1; i++)
        //            {

        //                xmlWriter.WriteStartElement("gunlukVeri");                                  //Element Açar
        //                xmlWriter.WriteAttributeString("yapilmis", "false");
        //                xmlWriter.WriteElementString("yapilacak", data[i]);
        //                xmlWriter.WriteEndElement();                                                            //Element Kapatır
        //            }

        //            xmlWriter.WriteEndElement();
        //            xmlWriter.WriteEndDocument();
        //            xmlWriter.Flush();
        //            xmlWriter.Close();
        //        }
        //    }
        //    else
        //    {
        //        XDocument xDocument = XDocument.Load("data-" + xmlTableName + ".xml");
        //        XElement root = xDocument.Element("date-" + xmlTableName);
        //        IEnumerable<XElement> rows = root.Descendants("gunlukVeri");
        //        XElement lastRow = rows.Last();
        //        for (int i = 0; i <= data.Length - 1; i++)
        //        {
        //            lastRow.AddBeforeSelf(
        //           new XElement("gunlukVeri",
        //           new XElement("yapilacak", data[i]),
        //           new XAttribute("yapilmis","false")));
        //        }
        //        xDocument.Save("data-" + xmlTableName + ".xml");
        //    }
        //}
        #endregion

        public DataSet newImport()
        {
            string xmlTableName = DateTime.Today.ToShortDateString();
            xmlTableName = xmlTableName.Replace("/", ".");
            //if (File.Exists("data-" + xmlTableName + ".xml"))
            if (File.Exists("dataTest.xml"))
            {
                DataSet newData = new DataSet();
                //newData.ReadXml("data-" + xmlTableName + ".xml");
                newData.ReadXml("dataTest.xml");
                return newData;
            }
            return null;
        }

        public void newExport()
        {
            DataSet newData = new DataSet();
            string xmlTableName = DateTime.Today.ToShortDateString();
            xmlTableName = xmlTableName.Replace("/", ".");
            xmlTableName = "date-" + xmlTableName + "-data";
            newData.DataSetName = xmlTableName;
            //if (!File.Exists("dataTest.xml"))
            //{
                newData.Tables.Add("gunlukVeri");
                newData.Tables[0].Columns.Add("kategori");
                newData.Tables[0].Columns.Add("yapilmis");
                newData.Tables[0].Columns.Add("yapilacak");

                //for (int i = 0; i <= this.exportedData.Length - 1; i++)
                //{
                //    string[] row = new string[] { "is", "false", this.exportedData[i] };
                //    newData.Tables[0].Rows.Add(row);
                //}

                int satir = this.newExportedData.GetLength(0);
                int sutun = this.newExportedData.GetLength(1);
                //string[] row = new string[3];

                for (int i = 0; i <= satir-1; i++)
                {
                    string[] row = new string[] { this.newExportedData[i, 0], this.newExportedData[i, 1], this.newExportedData[i, 2] };
                    newData.Tables[0].Rows.Add(row);
                    //for(int j = 0; j<= sutun-1; j++)
                    //{
                    //    row[j] = newExportedData[i, j];
                    //}
                    //newData.Tables[0].Rows.Add(row);
                    //System.GC.SuppressFinalize(row);
                }

            newData.WriteXml("dataTest.xml");
            //}
            //else
            //{
                // Buraya karşılaştırma gelecek şimdilik böyle.
                //newData.ReadXml("dataTest.xml");
                //int columnCount = newData.Tables[0].Columns.Count;
                //for (int i = 0; i <= this.newExportedData.GetUpperBound(0); i++)
                //{
                //    string[] row = new string[] { this.newExportedData[i,0], this.newExportedData[i,1], this.newExportedData[i, 2] };
                //    newData.Tables[0].Rows.Add(row);
                //}
                //newData.WriteXml("dataTest.xml");
            //}
        }

        public DataSet kategoriImport()
        {
            string xmlTableName = DateTime.Today.ToShortDateString();
            xmlTableName = xmlTableName.Replace("/", ".");
            if (File.Exists("kategoriSettings.xml"))
            {
                DataSet newData = new DataSet();
                newData.ReadXml("kategoriSettings.xml");
                return newData;
            }
            return null;
        }
    }
}
