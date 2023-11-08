using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OpenTextFiles12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opens file
            StreamReader fileToOpen = new StreamReader("U:/wordsfile.txt");
            // Read file and output all contents to the console
            // Console.WriteLine(fileToOpen.ReadToEnd());
            // Read a single line and output to the console
            // Console.WriteLine(fileToOpen.ReadLine());
            // Console.WriteLine(fileToOpen.ReadLine());
            //do
            //{
            //    Console.WriteLine(fileToOpen.ReadLine());
            //}while(!fileToOpen.EndOfStream);
            // Read file and save in variable
            //string fileContents = fileToOpen.ReadToEnd();
            List<string> lines = new List<string>();
            do {
                lines.Add(fileToOpen.ReadLine());
            }while(!fileToOpen.EndOfStream);

            for(int i = 0; i < lines.Count; i++)
            {
                Console.WriteLine(lines[i]);
            }

            // Close file
            fileToOpen.Close();

        }
    }
}
