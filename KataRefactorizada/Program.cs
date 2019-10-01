using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRefactorizada
{
    class Program
    {
        static Item[] items;

        static void Main(string[] args)
        {
            for (int i = 0; i < items.Length; i++)
            {
                items[i].Update();
            }
        }
    }
}
