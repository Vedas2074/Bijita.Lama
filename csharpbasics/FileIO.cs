using System;
using System.IO;
namespace FileDirectoryHandling
{
    public class FileIO
    {
        public void LearnFileReading()
        {
            string fileContent = File.ReadAllText("Test.txt");
            Console.WriteLine(fileContent);
        }
        public void LearnFileWriting()
        {
            File.WriteAllText("A", "this is new file.");
        }
        public void LearnFileInfo()//for meta data
        {
            FileInfo fileInfo = new FileInfo("A.txt");
            var x = fileInfo.Length;
            var y = fileInfo.CreationTime;
            var z = fileInfo.DirectoryName;

            Console.WriteLine($"File Size: {x} bytes");
            Console.WriteLine($"Created: {y}");
            Console.WriteLine($"Directory: {z}");
        }
        internal void LearnDirectory()
        {
            Directory.CreateDirectory("ABC");//inside respective folder. To creste in other place we need to give path
            File.WriteAllText(@"ABC\a.bijita", "This is my new file.");

        }
        internal void LearnDirectoryInfo()
        {
            string folderPath = @"D:\labwork6sem\vedas lab\Bijita.Lama";
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            var files = directory.GetFiles();
            Console.WriteLine("File count: " + files.Length);
        }
    }
}