using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace POC_File_IO.Models
{
    internal class WritingTheFile
    {
        public static void WriteXmlFile(string filePath, string input)
        {
            //Creating a object to load and write the xml file
            XmlDocument xmlFile = new XmlDocument();
            xmlFile.Load(filePath);

            XmlElement newData = xmlFile.CreateElement("Data");
            newData.InnerText = input;

            //Adding the data
            xmlFile.DocumentElement.AppendChild(newData);

            xmlFile.Save(filePath);
        }

        //writing the html file by using AppendAlltext
        public static void WriteHtmlFile(string filePath, string input)
        {
            string content = $"<p>{input}</p>\n";
            File.AppendAllText(filePath, content);
        }

        //Writing the Text file by AppendAllText
        public static void WriteTextFile(string filePath, string input)
        {
            File.AppendAllText(filePath, input + Environment.NewLine);
        }
    }
}
