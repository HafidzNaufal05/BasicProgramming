using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming2
{
    class Menu_4
    {
        int Angka;
        private void setAngka(int angka)
        {
            this.Angka = angka;
        }
        private int getAngka()
        {
            return Angka;
        }


        public void SUMArray()
        {
            Console.WriteLine("Input Length Array : ");
            setAngka(Angka = Convert.ToInt16(Console.ReadLine()));
            int[] temp = new int[getAngka()];
            int total = 0;
            for (int i = 1; i <= getAngka(); i++)
            {
                temp[i - 1] = int.Parse(Console.ReadLine());
                total = total + temp[i - 1];
            }
            Console.WriteLine("Total SUM = " + total);
        }
    }
}
