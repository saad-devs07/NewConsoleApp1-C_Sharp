using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConsoleApp1
{
    internal class MyClass
    {
        //public MyClass()
        //{
        //    Console.WriteLine("The Auto Fired Constructor From MyCLass!");
        //}

        public void table()
        {
            Console.WriteLine("Customised Table!");

            int Table, Start, End;

            Console.WriteLine("Enter number whose table you want: ");
            Table = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter starting number: ");
            Start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter ending number: ");
            End = int.Parse(Console.ReadLine());

            for(int i = Start; i <= End; i++)
            {
                Console.WriteLine(Table + " x " + i + " = " + (i * Table));
            }
        }
    }
}
