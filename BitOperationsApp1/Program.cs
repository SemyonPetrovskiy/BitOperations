using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOperationsApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Логические операции 
            // & - амперсанд ---------------------------------

            int x1 = 2; // 010 двоичное представление 2
            int y1 = 5; // 101 двоичное представление 5
                        // 000 - 0 
            Console.WriteLine(x1 & y1);

            int x2 = 4; // 100 двоичное представление 4
            int y2 = 5; // 101 двоичное представление 5
                        // 100 - 0 
            Console.WriteLine(x2 & y2);

            int x3 = 0b100; // 4 в двоичном представлении
            int y3 = 0b101; // 5
                        // 100 - 4 
            Console.WriteLine(x3);
            Console.WriteLine(y3);
            Console.WriteLine(x3 & y3);

            // | - сложение --------------------------------

            int x4 = 2; // 010 двоичное представление 2
            int y4 = 5; // 101 двоичное представление 5
                        // 111 - 07 
            Console.WriteLine(x4 | y4);

            int x5 = 4; // 100 двоичное представление 4
            int y5 = 5; // 101 двоичное представление 5
                        // 101 - 5 
            Console.WriteLine(x5 | y5);

            int x6 = 0b100; // 4 в двоичном представлении
            int y6 = 0b101; // 5
                            // 101 - 5 
            Console.WriteLine(x6);
            Console.WriteLine(y6);
            Console.WriteLine(x6 | y6);

            // ^ - исключающее или {шифрование} (XOR) ----------------------------------

            int x7 = 45;            // 0101101
            int Key = 102;          // 1100110
            int encrypt = x7 ^ Key; // 1001011 - 75

            Console.WriteLine(encrypt);

            int dencrypt = encrypt ^ Key; // дешифрование с помощью ключа key

            Console.WriteLine(dencrypt);

            // ~ {наз. тильда} логическое отрицание (инверсия)---------------

            int x8 = 9;             // 1001 (4 бита) - 9 инверсия 0110; int хранит 32 бит

            Console.WriteLine(~x8); // -10
            Console.WriteLine(Convert.ToString(-10, 2)); // представление числа -10 в 2-й системе

            // операции сдвига 

            int x9 = 4; // 100
            Console.WriteLine(x9<<1); // 1000 - 8
            Console.WriteLine(x9 << 2); // 10000 - 16
            Console.WriteLine(x9 >> 1); // 10  - 2
            Console.WriteLine(x9 >> 2); // 1  - 1


            Console.ReadKey();
        }
    }
}
