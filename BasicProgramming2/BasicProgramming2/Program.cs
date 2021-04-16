using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming2
{
    class Program
    {
        static void AwalProgram()
        {
            Menu_1 menu1 = new Menu_1();
            Menu_2 menu2 = new Menu_2();
            Menu_3 menu3 = new Menu_3();
            Menu_4 menu4 = new Menu_4();

            try
            {
                Console.WriteLine("Input Number From 1-4");
                Console.WriteLine("1. Body Mas Index");
                Console.WriteLine("2. Reprint Name");
                Console.WriteLine("3. Print Even's Character");
                Console.WriteLine("4. Sum the Inputted Array");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        menu1.BMI();
                        break;

                    case "2":
                        menu2.ReprintName();
                        break;
                    case "3":
                        menu3.ReprintName();
                        break;
                    case "4":
                        menu4.SUMArray();
                        break;
                    default:
                        Console.WriteLine("Please Input Number form 1-4");
                        break;
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Please Input Your Number form 1-4");
            }
            
        }
        static void Main(string[] args)
        {
            AwalProgram();
            int i = 1;
            while (i > 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Apakah akan kembali ke menu utama (yes/no)");
                string ans = Console.ReadLine();
                if (ans.ToLower() == "yes")
                {
                    AwalProgram();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
