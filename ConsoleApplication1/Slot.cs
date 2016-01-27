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
        }

        public void CreateBlankPuzzle(List<Slot> slotList)
        {
            for (int i = 0; i < 81; i++)
            {
                temp = new Slot((i % 9) + 1, i);
                slotList.Add(temp);
            }
        }
        public List<Slot> solveRowsAndColumns(List<Slot> listBeforeSolve)
        {
            List<Slot> newList = new List<Slot>();
            newList.Add(new Slot(0, 0));

            return newList;
        }

    }
}
