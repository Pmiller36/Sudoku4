using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Slot
    {
        public int num;
        public int pos;
        Slot temp;
        public int row, column, nonet;
        public int currentRow, currentColumn, currentNonet;
        bool detects1, detects2, detects3, detects4, detects5, detects6, detects7, detects8, detects9;
        int totalPrinted;
        int totalMissing;



        public Slot(int number, int position)
        {
            if (number > 9)
            {
                number = 0;
            }
            else if (number < 0)
            {
                number = 0;
            }

            num = number;
            pos = position;
            //mod determines the column, division determines row. 
            column = pos % 9;
            row = pos / 9;

            //hella loops determine nonets:
            #region Determine Nonets
            if (row < 3)
            {
                if (column < 3)
                {
                    nonet = 0;
                }
                else if (column >= 3 && column <= 5)
                {
                    nonet = 1;
                }
                else if (column > 5)
                {
                    nonet = 2;
                }
            }
            else if (row >= 3 && row <= 5)
            {
                if (column < 3)
                {
                    nonet = 3;
                }
                else if (column >= 3 && column <= 5)
                {
                    nonet = 4;
                }
                else if (column > 5)
                {
                    nonet = 5;
                }
            }
            else if (row > 5)
            {
                if (column < 3)
                {
                    nonet = 6;
                }
                else if (column >= 3 && column <= 5)
                {
                    nonet = 7;
                }
                else if (column > 5)
                {
                    nonet = 8;
                }
            }
            #endregion
        }

        public void CreateBlankPuzzle(List<Slot> slotList)
        {
            for (int i = 0; i < 81; i++)
            {
                temp = new Slot((i % 9) + 1, i);
                slotList.Add(temp);
            }
        }
        public bool PuzzleSolved(List<Slot> slotList)
        {
            totalMissing = 0;
            foreach (Slot s in slotList)
            {
                if (s.num == 0)
                {
                    totalMissing++;
                }
            }
            if (totalMissing > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int NumbersMissing(List<Slot> slotList)
        {
            totalMissing = 0;
            foreach (Slot s in slotList)
            {
                if (s.num == 0)
                {
                    totalMissing++;
                }
            }
            return totalMissing;
        }
        public void PrintPuzzle(List<Slot> slotList)
        {
            totalPrinted = 0;
            foreach (Slot s in slotList)
            {
                if (s.pos % 27 == 0)
                {
                    Console.WriteLine("_______________________");
                }

                Console.Write(s.num + " ");

                if ((s.pos + 1) % 3 == 0)
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
        }
        public List<Slot> Solve(List<Slot> listBeforeSolve)
        {
            List<Slot> newList = new List<Slot>();
            newList = listBeforeSolve;


            #region Actual Solving here
            foreach (Slot s in newList)
            {
                if (s.num == 0) //first, make sure the current slot isn't already filled. If it is, do nothing.
                {
                    //at the start, set everything back to false. 
                    detects1 = detects2 = detects3 = detects4 = detects5 = detects6 = detects7 = detects8 = detects9 = false;
                    //first, identify row, column, and nonet of 's'.
                    //The first 's' has a position of 0: it is in the 0 row and 0 column and 0 nonet.
                    currentColumn = s.column;
                    currentRow = s.row;
                    currentNonet = s.nonet;

                    //Next, Check each position's row, column, and nonet for numbers. Toggle booleans to keep track.
                    #region rowCheck
                    foreach (Slot rowCheck in newList)
                    {
                        if (rowCheck.row == currentRow) //they are in the same row
                        {
                            if (rowCheck.num == 1)
                                detects1 = true;
                            else if (rowCheck.num == 2)
                                detects2 = true;
                            else if (rowCheck.num == 3)
                                detects3 = true;
                            else if (rowCheck.num == 4)
                                detects4 = true;
                            else if (rowCheck.num == 5)
                                detects5 = true;
                            else if (rowCheck.num == 6)
                                detects6 = true;
                            else if (rowCheck.num == 7)
                                detects7 = true;
                            else if (rowCheck.num == 8)
                                detects8 = true;
                            else if (rowCheck.num == 9)
                                detects9 = true;
                        }
                    }
                    #endregion

                    #region columnCheck
                    foreach (Slot columnCheck in newList)
                    {
                        if (columnCheck.column == currentColumn) //they are in the same column
                        {
                            if (columnCheck.num == 1)
                                detects1 = true;
                            else if (columnCheck.num == 2)
                                detects2 = true;
                            else if (columnCheck.num == 3)
                                detects3 = true;
                            else if (columnCheck.num == 4)
                                detects4 = true;
                            else if (columnCheck.num == 5)
                                detects5 = true;
                            else if (columnCheck.num == 6)
                                detects6 = true;
                            else if (columnCheck.num == 7)
                                detects7 = true;
                            else if (columnCheck.num == 8)
                                detects8 = true;
                            else if (columnCheck.num == 9)
                                detects9 = true;
                        }
                    }
                    #endregion

                    #region nonetCheck
                    foreach (Slot nonetCheck in newList)
                    {
                        if (nonetCheck.nonet == currentNonet) //they are in the same nonet
                        {
                            if (nonetCheck.num == 1)
                                detects1 = true;
                            else if (nonetCheck.num == 2)
                                detects2 = true;
                            else if (nonetCheck.num == 3)
                                detects3 = true;
                            else if (nonetCheck.num == 4)
                                detects4 = true;
                            else if (nonetCheck.num == 5)
                                detects5 = true;
                            else if (nonetCheck.num == 6)
                                detects6 = true;
                            else if (nonetCheck.num == 7)
                                detects7 = true;
                            else if (nonetCheck.num == 8)
                                detects8 = true;
                            else if (nonetCheck.num == 9)
                                detects9 = true;
                        }
                    }
                    #endregion

                    //Place numbers.
                    //If all but 1 number is detected, input that remaining number
                    if (!detects1 && detects2 && detects3 && detects4 && detects5 && detects6 && detects7 && detects8 && detects9)
                        s.num = 1;   //detects everything but 1
                    else if (detects1 && !detects2 && detects3 && detects4 && detects5 && detects6 && detects7 && detects8 && detects9)
                        s.num = 2;   //detects everything but 2
                    else if (detects1 && detects2 && !detects3 && detects4 && detects5 && detects6 && detects7 && detects8 && detects9)
                        s.num = 3;   //detects everything but 3
                    else if (detects1 && detects2 && detects3 && !detects4 && detects5 && detects6 && detects7 && detects8 && detects9)
                        s.num = 4;   //detects everything but 4
                    else if (detects1 && detects2 && detects3 && detects4 && !detects5 && detects6 && detects7 && detects8 && detects9)
                        s.num = 5;   //detects everything but 5
                    else if (detects1 && detects2 && detects3 && detects4 && detects5 && !detects6 && detects7 && detects8 && detects9)
                        s.num = 6;   //detects everything but 6
                    else if (detects1 && detects2 && detects3 && detects4 && detects5 && detects6 && !detects7 && detects8 && detects9)
                        s.num = 7;   //detects everything but 7
                    else if (detects1 && detects2 && detects3 && detects4 && detects5 && detects6 && detects7 && !detects8 && detects9)
                        s.num = 8;   //detects everything but 8
                    else if (detects1 && detects2 && detects3 && detects4 && detects5 && detects6 && detects7 && detects8 && !detects9)
                        s.num = 9;   //detects everything but 9
                }
            }

            #endregion

            return newList;
        }
        public void SolveAndPrint(List<Slot> slotList)
        {
            int iterations = 0;
            Console.WriteLine("The puzzle is missing " + NumbersMissing(slotList) + " numbers.");
            Console.WriteLine("Press enter to see the next iteration.");
            Console.ReadLine();

            while (NumbersMissing(slotList) > 0)
            {
                Solve(slotList);
                PrintPuzzle(slotList);

                if (NumbersMissing(slotList) > 0)
                {
                    Console.Write("The puzzle is now only missing " + NumbersMissing(slotList));
                    if (NumbersMissing(slotList) == 1)
                    {
                        Console.WriteLine(" number.");
                    }
                    else if (NumbersMissing(slotList) > 1)
                    {
                        Console.WriteLine(" numbers.");
                    }
                    Console.WriteLine("Press enter to see the next iteration.");
                    Console.WriteLine("_____________________________________________________________________________");
                }
                else if (NumbersMissing(slotList) == 0)
                {
                    Console.WriteLine("Done! Press enter for more information.");
                }

                Console.ReadLine();
                iterations++;
            }
            Console.WriteLine("This took " + iterations + " passes through to solve!");
        }
    }
}
