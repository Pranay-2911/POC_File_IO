using POC_File_IO.Models;

namespace POC_File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string xmlFilePath = "C:\\Users\\pranay raut\\Desktop\\DOTNET\\Demo.xml";
            string htmlFilePath = "C:\\Users\\pranay raut\\Desktop\\DOTNET\\Demo.html";
            string textFilePath = "C:\\Users\\pranay raut\\Desktop\\DOTNET\\Demo.txt";

            //Reading the file
            Console.WriteLine(ReadingTheFile.ReadXmlFile(xmlFilePath));
            Console.WriteLine(ReadingTheFile.ReadHtmlFile(htmlFilePath));
            Console.WriteLine(ReadingTheFile.ReadTextFile(textFilePath));

            //Entering the data for writing
            Console.WriteLine("Enter the Data to write in file");
            string data = Console.ReadLine();
            Console.WriteLine();

            WritingTheFile.WriteXmlFile(xmlFilePath, data);
            Console.WriteLine(ReadingTheFile.ReadXmlFile(xmlFilePath));

            WritingTheFile.WriteTextFile(textFilePath, data);
            Console.WriteLine(ReadingTheFile.ReadTextFile(textFilePath));

            WritingTheFile.WriteHtmlFile(htmlFilePath, data);
            Console.WriteLine(ReadingTheFile.ReadHtmlFile(htmlFilePath));
        }
    }
}
