using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming2
{
    class Menu_2
    {
        string Name;
        public virtual void setName(string nama)
        {
            this.Name = nama;
        }
        public virtual string getName()
        {
            return Name;
        }

        public virtual void ReprintName()
        {
            Console.WriteLine("Input Name : ");
            setName(Name = Console.ReadLine());
            char[] huruf = getName().ToCharArray();
            int length = huruf.Count();
            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine("Huruf ke " + i + " adalah " + huruf[i - 1]);
            }
        }
    }
}
