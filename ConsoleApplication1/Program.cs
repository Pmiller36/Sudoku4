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
            string directoryForPuzzle = "ConsoleApplication1/ConsoleApplication1/bin/Debug/Sudoku Test X.txt";
            int totalPrinted = 0;
            List<Slot> sampleSlotList = new List<Slot>();
            List<Slot> actualPuzzle = new List<Slot>();
            List<Int16> actualPuzzleNumbers = new List<Int16>();
            string actualNumbersRead = "";
            List<Slot> puzzleSolution = new List<Slot>();
            int errors = 0;
            int puzzleInput;
            puzzleInput = 5;

            //puzzle string sets
            string set1, set2, set3, set4, set5, set6, set7, set8, set9;
            set1 = set2 = set3 = set4 = set5 = set6 = set7 = set8 = set9 = "";

            //solution string sets
            string set1s, set2s, set3s, set4s, set5s, set6s, set7s, set8s, set9s;
            set1s = set2s = set3s = set4s = set5s = set6s = set7s = set8s = set9s = "";


            Console.WriteLine("Welcome to Sudoku Solver!!!" + "\n\n" + "Please put your puzzle at: \n" + "\"" + directoryForPuzzle + "\""
                + "\n \n" + "And place your solution at: \n" + "\"" + "ConsoleApplication1/ConsoleApplication1/bin/Debug/Sudoku Test X Solution.txt" + "\", \n Where X is the number you desire.");
            Console.Write("\n \n \n Input a puzzle/solution number to begin, or enter 5 for a demo: ");
            puzzleInput = Int32.Parse(Console.ReadLine());
            

            try
            {
                //using (StreamReader sr = new StreamReader("Sudoku Test 2.txt"))
                //{
                //    actualNumbersRead = sr.ReadToEnd();
                //}
                using (StreamReader sr = new StreamReader("Sudoku Test " + puzzleInput + ".txt"))
                {
                    set1 = sr.ReadLine();
                    set2 = sr.ReadLine();
                    set3 = sr.ReadLine();
                    set4 = sr.ReadLine();
                    set5 = sr.ReadLine();
                    set6 = sr.ReadLine();
                    set7 = sr.ReadLine();
                    set8 = sr.ReadLine();
                    set9 = sr.ReadLine();
                }
                using (StreamReader sr = new StreamReader("Sudoku Test " + puzzleInput + " solution.txt"))
                {
                    set1s = sr.ReadLine();
                    set2s = sr.ReadLine();
                    set3s = sr.ReadLine();
                    set4s = sr.ReadLine();
                    set5s = sr.ReadLine();
                    set6s = sr.ReadLine();
                    set7s = sr.ReadLine();
                    set8s = sr.ReadLine();
                    set9s = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Char delimiter = ',';
            String[] substrings = actualNumbersRead.Split(delimiter);
            String[] sub1 = set1.Split(delimiter);
            String[] sub2 = set2.Split(delimiter);
            String[] sub3 = set3.Split(delimiter);
            String[] sub4 = set4.Split(delimiter);
            String[] sub5 = set5.Split(delimiter);
            String[] sub6 = set6.Split(delimiter);
            String[] sub7 = set7.Split(delimiter);
            String[] sub8 = set8.Split(delimiter);
            String[] sub9 = set9.Split(delimiter);

            String[] sub1s = set1s.Split(delimiter);
            String[] sub2s = set2s.Split(delimiter);
            String[] sub3s = set3s.Split(delimiter);
            String[] sub4s = set4s.Split(delimiter);
            String[] sub5s = set5s.Split(delimiter);
            String[] sub6s = set6s.Split(delimiter);
            String[] sub7s = set7s.Split(delimiter);
            String[] sub8s = set8s.Split(delimiter);
            String[] sub9s = set9s.Split(delimiter);



            for(int i = 0; i < 9; i++)
            {
                if (sub1[i] == "")
                {
                    tempAdd = new Slot(0, i);
                    actualPuzzle.Add(tempAdd);
                }
                else
                {
                    tempAdd = new Slot(Int32.Parse(sub1[i]), i);
                    actualPuzzle.Add(tempAdd);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (sub2[i] == "")
                {
                    tempAdd = new Slot(0, i+9);
                    actualPuzzle.Add(tempAdd);
                }
                else
                {
                    tempAdd = new Slot(Int32.Parse(sub2[i]), i+9);
                    actualPuzzle.Add(tempAdd);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (sub3[i] == "")
                {
                    tempAdd = new Slot(0, i+18);
                    actualPuzzle.Add(tempAdd);
                }
                else
                {
                    tempAdd = new Slot(Int32.Parse(sub3[i]), i+18);
                    actualPuzzle.Add(tempAdd);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (sub4[i] == "")
                {
                    tempAdd = new Slot(0, i+27);
                    actualPuzzle.Add(tempAdd);
                }
                else
                {
                    tempAdd = new Slot(Int32.Parse(sub4[i]), i+27);
                    actualPuzzle.Add(tempAdd);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (sub5[i] == "")
                {
                    tempAdd = new Slot(0, i+36);
                    actualPuzzle.Add(tempAdd);
                }
                else
                {
                    tempAdd = new Slot(Int32.Parse(sub5[i]), i+36);
                    actualPuzzle.Add(tempAdd);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (sub6[i] == "")
                {
                    tempAdd = new Slot(0, i+45);
                    actualPuzzle.Add(tempAdd);
                }
                else
                {
                    tempAdd = new Slot(Int32.Parse(sub6[i]), i+45);
                    actualPuzzle.Add(tempAdd);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (sub7[i] == "")
                {
                    tempAdd = new Slot(0, i+54);
                    actualPuzzle.Add(tempAdd);
                }
                else
                {
                    tempAdd = new Slot(Int32.Parse(sub7[i]), i+54);
                    actualPuzzle.Add(tempAdd);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (sub8[i] == "")
                {
                    tempAdd = new Slot(0, i+63);
                    actualPuzzle.Add(tempAdd);
                }
                else
                {
                    tempAdd = new Slot(Int32.Parse(sub8[i]), i+63);
                    actualPuzzle.Add(tempAdd);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (sub9[i] == "")
                {
                    tempAdd = new Slot(0, i+72);
                    actualPuzzle.Add(tempAdd);
                }
                else
                {
                    tempAdd = new Slot(Int32.Parse(sub9[i]), i+72);
                    actualPuzzle.Add(tempAdd);
                }
            }



            //Input the solution numbers
            for (int i = 0; i < 9; i++)
            {
                tempAdd = new Slot(Int32.Parse(sub1s[i]), i);
                puzzleSolution.Add(tempAdd);
            }
            for (int i = 0; i < 9; i++)
            {
                tempAdd = new Slot(Int32.Parse(sub2s[i]), i+9);
                puzzleSolution.Add(tempAdd);
            }
            for (int i = 0; i < 9; i++)
            {
                tempAdd = new Slot(Int32.Parse(sub3s[i]), i+18);
                puzzleSolution.Add(tempAdd);
            }
            for (int i = 0; i < 9; i++)
            {
                tempAdd = new Slot(Int32.Parse(sub4s[i]), i+27);
                puzzleSolution.Add(tempAdd);
            }
            for (int i = 0; i < 9; i++)
            {
                tempAdd = new Slot(Int32.Parse(sub5s[i]), i+36);
                puzzleSolution.Add(tempAdd);
            }
            for (int i = 0; i < 9; i++)
            {
                tempAdd = new Slot(Int32.Parse(sub6s[i]), i+45);
                puzzleSolution.Add(tempAdd);
            }
            for (int i = 0; i < 9; i++)
            {
                tempAdd = new Slot(Int32.Parse(sub7s[i]), i+54);
                puzzleSolution.Add(tempAdd);
            }
            for (int i = 0; i < 9; i++)
            {
                tempAdd = new Slot(Int32.Parse(sub8s[i]), i+63);
                puzzleSolution.Add(tempAdd);
            }
            for (int i = 0; i < 9; i++)
            {
                tempAdd = new Slot(Int32.Parse(sub9s[i]), i+72);
                puzzleSolution.Add(tempAdd);
            }




            //for (int i = 0; i < 81; i++)
            //{
            //    if (substrings[i] == "")
            //    {
            //        substrings[i] = "0";
            //    }
            //    tempAdd = new Slot(Int32.Parse(substrings[i]), i);
            //    actualPuzzle.Add(tempAdd);
            //}



            tempMain.CreateBlankPuzzle(sampleSlotList);

            

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

            Console.WriteLine("The puzzle entered is above. Press enter for more information.");

            Console.ReadLine();

            //static amount of solve times
            //for (int i = 0; i < 500; i++)
            //{
            //    tempMain.SolveRowsAndColumns(actualPuzzle);
            //}

            //dynamic amount of solve times

            tempMain.SolveAndPrint(actualPuzzle);

            Console.WriteLine("Checking with solution...");
            for (int i = 0; i < 81; i++)
            {
                if (actualPuzzle[i].num != puzzleSolution[i].num)
                {
                    errors++;
                }
            }
            Console.WriteLine("There were " + errors + " errors, as checked with the solution.");



            Console.WriteLine("\n \n \n \n \n");
            Console.WriteLine("The program has ended. Press enter to exit.");
            Console.ReadLine();
        }
    }
}
