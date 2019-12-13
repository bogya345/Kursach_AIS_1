using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;
using System.IO;

using System.Collections.ObjectModel;

using WpfAppAbit2.Models;

namespace WpfAppAbit2.XML
{
    class xml
    {
        private XmlDocument doc;
        //private xmlContent xmlContent;
        private ObservableCollection<EntrantApplication> applications;
        private ListOfEntrantApplication appsXml;

        public xml(ObservableCollection<EntrantApplication> applications)
        {
            doc = new XmlDocument();

            this.applications = applications;
            appsXml = new ListOfEntrantApplication(applications);
        }

        public void SetAuthData(string login = "", string pass = "")
        {

        }

        public void SetContent()
        {
            XmlSerializer xml = new XmlSerializer(typeof(ListOfEntrantApplication));

            using (FileStream fs = new FileStream("apps.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, appsXml);
            }
        }

        //public void SetContent()
        //{
        //    XmlElement aaps = doc.CreateElement("Applications");

        //    int i = 0;

        //    foreach (EntrantApplication item in applications)
        //    {
        //        XmlElement app = doc.CreateElement("Application");

        //        XmlElement uid = doc.CreateElement("UID");
        //        XmlText uidContent = doc.CreateTextNode(i++.ToString());
        //        uid.AppendChild(uidContent);

        //        XmlElement applNum = doc.CreateElement("ApplicationNumber");
        //        XmlText applNumContent = doc.CreateTextNode(i++.ToString());
        //        uid.AppendChild(applNumContent);

        //        XmlElement entrant = item.Entrant.GetAsXmlElement(doc);

        //        XmlElement uid = doc.CreateElement("UID");
        //        XmlText uidContent = doc.CreateTextNode(i++.ToString());
        //        uid.AppendChild(uidContent);

        //        XmlElement uid = doc.CreateElement("UID");
        //        XmlText uidContent = doc.CreateTextNode(i++.ToString());
        //        uid.AppendChild(uidContent);

        //        XmlElement uid = doc.CreateElement("UID");
        //        XmlText uidContent = doc.CreateTextNode(i++.ToString());
        //        uid.AppendChild(uidContent);
        //    }
        //}
    }
}
