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
            Console.WriteLine("Input Number From 1-4");
            Console.WriteLine("1. Body Mas Index");
            Console.WriteLine("2. Reprint Name");
            Console.WriteLine("3. Print Even's Character");
            Console.WriteLine("4. Sum the Inputted Array");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Input Your weight (kg) : ");
                    double bb = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input Your Height (cm): ");
                    double tb = Convert.ToDouble(Console.ReadLine());
                    double BMI = bb / (Math.Pow(tb, 2));
                    if (BMI < 18.1)
                    {
                        Console.WriteLine("Your Body Mas Index Is : Underweight");
                    }
                    else if (BMI >= 18.1 && BMI < 23.1)
                    {
                        Console.WriteLine("Your Body Mas Index Is : Normal");
                    }
                    else if (BMI >= 23.1 && BMI < 28.1)
                    {
                        Console.WriteLine("Your Body Mas Index Is : Overweight");
                    }
                    else if (BMI >= 28.1)
                    {
                        Console.WriteLine("Your Body Mas Index Is : Obesitas");
                    }
                    break;

                case "2":
                    Console.WriteLine("Input Name : ");
                    string name2 = Console.ReadLine();
                    char[] huruf2 = name2.ToCharArray();
                    int length2 = huruf2.Count();
                    for (int i = 1; i <= length2; i++)
                    {
                        Console.WriteLine("Huruf ke " + i + " adalah " + huruf2[i - 1]);
                    }
                    break;
                case "3":
                    Console.WriteLine("Input Name : ");
                    string name3 = Console.ReadLine();
                    char[] huruf3 = name3.ToCharArray();
                    int length3 = huruf3.Count();
                    for (int i = 1; i <= length3; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine("Huruf ke " + i + " adalah " + huruf3[i - 1]);
                        }
                    }
                    break;
                case "4":
                    Console.WriteLine("Input Length Array : ");
                    int angka = Convert.ToInt16(Console.ReadLine());
                    int[] temp = new int[angka];
                    int tot = 0;
                    for (int i = 1; i <= angka; i++)
                    {
                        temp[i - 1] = int.Parse(Console.ReadLine());
                        tot = tot + temp[i - 1];
                    }
                    Console.WriteLine("Total SUM = " + tot);
                    break;
                default:
                    Console.WriteLine("Please Input Number From 1-4");
                    break;
            }
        }
        static void Main(string[] args)
        {
            AwalProgram();
            int i = 1;
            while (i > 0)
            {
                Console.WriteLine("Apakah akan kembali ke menu utama (yes/no)");
                string ans = Console.ReadLine();
                if (ans == "yes")
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
