using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\plaxi\OneDrive\Desktop\mytext.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter streamWriter = File.CreateText(path))
                {
                    streamWriter.WriteLine("the file ");
                    streamWriter.WriteLine("made by plaxidia ");
                }
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string textFound;
                    textFound = streamReader.ReadLine();
                    while ((textFound = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(textFound);
                    }
                }
            }
        }
    }
}
