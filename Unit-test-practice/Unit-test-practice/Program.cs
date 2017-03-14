using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_test_practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Hash("leepadg"));
            Console.ReadLine();
        }

        public static Int64 Hash(String str)
        {
            Int64 h = 0;
            String letters = "";
            Int64 i = 0;
            Int64 index = 0;
            Int64 inc = 0;

            h = 7;
            letters = "acdegilmnoprstuw";

            for (int x = 0; x < str.Length; x++)
            {
                inc = h * 37;
                index = letters.IndexOf(str[x]);
                h = inc + index;
            }

            return h;
        }

    }
}
