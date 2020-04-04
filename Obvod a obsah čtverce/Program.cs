using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obvod_a_obsah_čtverce
{
    class Square
    {
        int Num1;

        static void EnterTheNumbers()
        {

            Console.Write("Zadejte délku strany čtverce: ");
            Num1 = int.Parse(Console.ReadLine());
        }

        private int Total1;
        private int Total2;

        static void Calculation()
        {
            Total1 = Num1 * 4;
            Total2 = Num1 * Num1;
        }

        static void End()
        {
            Console.WriteLine("Obvod vašeho čtverce je: {0}", Total1);
            Console.WriteLine("Obsah vašeho čtverce je: {0}", Total2);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Square myFirstSquare = new Square();
            myFirstSquare.EnterTheNumbers();
            myFirstSquare.Calculation();
            myFirstSquare.End();


            Console.ReadKey();
        }
    }
}
