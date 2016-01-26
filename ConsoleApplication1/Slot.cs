using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Slot
    {
        public int num;
        public int pos;
        Slot temp = new Slot(0, 0);

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

        //public void createblankpuzzle()
        //{
        //    for (int i = 0; i < 81; i++)
        //    {
        //        temp = new slot((i + 1) % 9, i);
        //    }
        //}


    }
}
