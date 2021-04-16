using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming2
{
    class Menu_1
    {
        double BeratBadan, TinggiBadan;
        private void setBeratBadan(double bb)
        {
            this.BeratBadan = bb;
        }
        private void setTinggiBadan(double tb)
        {
            this.TinggiBadan = tb;
        }

        private double getBeratBadan()
        {
            return BeratBadan;
        }
        private double getTinggiBadan()
        {
            return TinggiBadan;
        }

        public void BMI()
        {
            Console.WriteLine("Input Your weight (kg) : ");
            setBeratBadan(BeratBadan = Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Input Your Height (cm): ");
            setTinggiBadan(TinggiBadan = Convert.ToDouble(Console.ReadLine()));
            double BMI = getBeratBadan() / (Math.Pow((getTinggiBadan()/100), 2));
            Console.WriteLine("");
            Console.WriteLine(Math.Round(BMI,2));
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
        }
    }
}
