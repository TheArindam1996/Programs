using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Demo2_mile2
{
    class Program
    {
        static string add(string input1,string input2)
        {
            BigInteger sum = BigInteger.Parse(input1) + BigInteger.Parse(input2);            
            return sum.ToString();
        }
        static void Main(string[] args)
        {
            string result=add(Console.ReadLine(),Console.ReadLine());
            Console.WriteLine(result);
        }
    }
}
