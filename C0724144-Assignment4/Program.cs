

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0724144_Assignment4
{

    class Program
    {
        ArrayList Beowulf;
        

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            p.ReadTextFiles();
            Console.WriteLine("\n");
            
            p.TotalWords();
            Console.WriteLine("\n");
            p.Both();
            Console.WriteLine("\n");
            p.NoFare();
            Console.ReadLine();
        }
        public void Run()
        {
            this.ReadTextFiles();
        }

        public void ReadTextFiles()
        {
            // Read file using StreamReader. Read file line by line
            using (StreamReader file = new StreamReader("Beowulf.txt"))
            {
                int counter = 0;
                string ln;
             
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                }
                file.Close();
                counter = File.ReadLines("Beowulf.txt").Count();
                Console.WriteLine("\n\n\nThe file has "+counter+" lines");
                }
            }
        public int FindNumberOfBlankSpaces(string line)
        {
            https://stackoverflow.com/questions/17812566/count-words-and-spaces-in-string-c-sharp
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }

                if (char.IsWhiteSpace(c)) { countletters++; }
            }
            return countSpaces;

        }
        
        public long TotalWords()
        {

            StreamReader reader = new StreamReader("Beowulf.txt");
            string script = reader.ReadToEnd();
            var text = script.Trim();
            long wordCount = 0; 
             int index = 0;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                index++;
                wordCount++;
                // skip whitespace until next word
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }
            Console.WriteLine("The file has "+wordCount+" words");
            return wordCount;
            
        }
        public void Both()
        {
            int a = 0;
            foreach (var lines in File.ReadAllLines("Beowulf.txt"))
            {
                a++;
                if (lines.Contains("sea") && lines.Contains("fare"))
                {
                    Console.WriteLine("The lines that contain words sea and fare are "+a);
                }
            }
        }

        public void NoFare()
        {
            int x = 0;
            foreach (var line in File.ReadAllLines("Beowulf.txt"))
            {
                x++;
                if (line.Contains("fare") && (!line.Contains("war")))
                {
                    Console.WriteLine("Lines in which fare comes and war does not are "+x);
                }
            }
        }



    }

        
    }

