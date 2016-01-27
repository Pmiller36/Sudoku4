//Program copyright by Patrick Miller Studios. 
//Please ask permission before re-use of code!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Slot tempMain = new Slot(0, 0);
            Slot tempAdd = new Slot(0, 0);
            string directoryForPuzzle = "%%/ConsoleApplication1/ConsoleApplication1/bin/Debug/Sudoku Test.txt";
            int totalPrinted = 0;
            List<Slot> sampleSlotList = new List<Slot>();
            List<Slot> actualPuzzle = new List<Slot>();
            List<Int16> actualPuzzleNumbers = new List<Int16>();
            string actualNumbersRead = "";

            try
            {
                using (StreamReader sr = new StreamReader("Sudoku Test.txt"))
                {
                    actualNumbersRead = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Char delimiter = ',';
            String[] substrings = actualNumbersRead.Split(delimiter);

            for(int i = 0; i < 81; i++)
            {
                tempAdd = new Slot(Int32.Parse(substrings[i]), i);
                actualPuzzle.Add(tempAdd);
            }
            tempMain.CreateBlankPuzzle(sampleSlotList);

            Console.WriteLine("Welcome to Sudoku Solver!!! Below is a Sample puzzle. " + "\n" + "Please enter your puzzle at: \n" + "\"" + directoryForPuzzle + "\"");

            foreach (Slot s in actualPuzzle)
            {
                if (s.pos % 27 == 0)
                {
                    Console.WriteLine("_______________________");
                }

                Console.Write(s.num + " ");

                if( (s.pos + 1) % 3 == 0)
                {
                    Console.Write("| ");
                }

                totalPrinted++;

                if (totalPrinted % 9 == 0)
                {
                    //totalPrinted = 0;
                    Console.WriteLine();
                }

                if (totalPrinted == 81)
                {
                    Console.WriteLine("_______________________");
                }
            }

            Console.ReadLine();
        }
    }
}
