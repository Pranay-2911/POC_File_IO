using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POC_File_IO.Models
{
    internal class ReadingTheFile
    {
        //method for reading Xml file
        public static string ReadXmlFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                XElement xml = XElement.Load(filePath);
                return "===== Xml file Content: ======\n" + $"{xml}\n";
            }
            return "Xml file not found.\n";
        }

        //Method for reading Html file
        public static string ReadHtmlFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string html = File.ReadAllText(filePath);
                return "===== Html file Content: =====\n" + $"{html}\n";
            }
            return "Html file not found.\n";
        }

       // Method of reading text file
        public static string ReadTextFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                StreamReader Textfile = new StreamReader(filePath);
                string line;
                var allText = "";

                while ((line = Textfile.ReadLine()) != null)
                {
                    allText = $"{allText}\n{line}";
                }

                Textfile.Close();
                return "===== Text file Content: =====\n" + $"{allText}\n";
            }
            return "Text file not found.\n";
        }

    }
}
