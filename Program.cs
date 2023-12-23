using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieveDataStudent1._13
{
    internal class Program
    {
        public static void Fun1()
        {
            string pathFile = @"D:\\Console Asp\RetrieveDataStudent1.13\\StudentData.txt";
            if (File.Exists(pathFile))
            {
                StreamReader sr = new StreamReader(pathFile);
                string tillEnd = sr.ReadToEnd();
                Console.WriteLine(tillEnd);
                sr.Close();
            }
            else
            {
                Console.WriteLine("File Not Found\nPlease Create StudentData.txt File\n");
                StreamWriter writer = new StreamWriter(pathFile);
                writer.Close();
            }
        }
        static void Main(string[] args)
        {
            Fun1();
        }
    }
}
