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
        Slot temp = new Slot(0,0);
        public void CreateBlankPuzzle()
        {
            for (int i = 0; i < 81; i++)
            {
                temp = new Slot((i + 1) % 9, i);
            }
        }


        static void Main(string[] args)
        {
            //CreateBlankPuzzle();



            Console.ReadLine();
        }
    }
}
