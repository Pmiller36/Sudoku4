using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
       
        //Globals
        //Slot temp = new Slot(0,0);
        //public void CreateBlankPuzzle()
        //{
        //    for (int i = 0; i < 81; i++)
        //    {
        //        temp = new Slot((i + 1) % 9, i);
        //    }
        //}


        static void Main(string[] args)
        {
            Slot tempMain = new Slot(0, 0);
            string directoryForPuzzle = "%%/solver/FilesHere";
            int totalPrinted = 0;
            List<Slot> sampleSlotList = new List<Slot>();
            tempMain.CreateBlankPuzzle(sampleSlotList);

            Console.WriteLine("Welcome to Sudoku Solver!!! Below is a Sample puzzle. Please enter your puzzle at: ");
            Console.WriteLine(directoryForPuzzle);

            foreach (Slot s in sampleSlotList)
            {
                if (s.pos % 27 == 0)
                {
                    Console.WriteLine("_______________________");
                }

                Console.Write(s.num + " ");

                if(s.num % 3 == 0)
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
