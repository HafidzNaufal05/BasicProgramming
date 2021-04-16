using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming2
{
    class Menu_3 : Menu_2
    {
        string Name;
        public override void setName(string nama)
        {
            this.Name = nama;
        }
        public override string getName()
        {
            return Name;
        }
        public override void ReprintName()
        {
            Console.WriteLine("Input Name : ");
            setName(Name = Console.ReadLine());
            char[] huruf = getName().ToCharArray();
            int length = huruf.Count();
            for (int i = 1; i <= length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Huruf ke " + i + " adalah " + huruf[i - 1]);
                }
            }
        }

    }
}
