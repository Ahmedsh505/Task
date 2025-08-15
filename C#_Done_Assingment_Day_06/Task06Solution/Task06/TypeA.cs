using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{

    // Problem01
    public class TypeA
    {


        private int F;
        internal int G;
        public int H;

        public TypeA(int f, int g, int h)
        {
            F = f;
            G = g;
            H = h;
        }

        public void RetrieveValues()
        {
            Console.WriteLine($"F: {F}, G: {G}, H: {H}");
        }
    }
}
