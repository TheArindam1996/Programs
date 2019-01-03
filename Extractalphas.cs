using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2_mile2
{
    class Extractalphas
    {
        static string ExtractVowelsNonVowels(string input1,int input2,int input3)
        {
            int i = 0;
            string concat = "",result="";
            
            if (input2 == 0)
            {
                for (i = 0; i < input1.Length; i++)
                {
                    if (input1.ElementAt(i) == 'b' || input1.ElementAt(i) == 'c' || input1.ElementAt(i) == 'd' ||input1.ElementAt(i) == 'f' || input1.ElementAt(i) == 'g' || input1.ElementAt(i) == 'h' ||input1.ElementAt(i) == 'j' || input1.ElementAt(i) == 'k' || input1.ElementAt(i) == 'l' || input1.ElementAt(i) == 'm'||input1.ElementAt(i) == 'n' || input1.ElementAt(i) == 'p' || input1.ElementAt(i) == 'q' ||input1.ElementAt(i) == 'r' || input1.ElementAt(i) == 's' || input1.ElementAt(i) == 't' ||input1.ElementAt(i) == 'v' || input1.ElementAt(i) == 'w' || input1.ElementAt(i) == 'x' || input1.ElementAt(i) == 'y'|| input1.ElementAt(i) == 'z'||input1.ElementAt(i) == 'B' || input1.ElementAt(i) == 'C' || input1.ElementAt(i) == 'D' || input1.ElementAt(i) == 'F' || input1.ElementAt(i) == 'G' || input1.ElementAt(i) == 'H' ||
                        input1.ElementAt(i) == 'J' || input1.ElementAt(i) == 'K' || input1.ElementAt(i) == 'L' || input1.ElementAt(i) == 'M' || input1.ElementAt(i) == 'N' || input1.ElementAt(i) == 'P' || input1.ElementAt(i) == 'Q' ||input1.ElementAt(i) == 'R' || input1.ElementAt(i) == 'S' || input1.ElementAt(i) == 'T' || input1.ElementAt(i) == 'V' || input1.ElementAt(i) == 'W' || input1.ElementAt(i) == 'X' || input1.ElementAt(i) == 'Y' || input1.ElementAt(i) == 'Z'  )
                    {
                        concat = concat + input1.ElementAt(i);
                    }
                }
                
            }
            else if(input2==1)
            {
                for (i = 0; i < input1.Length; i++)
                {
                    if (input1.ElementAt(i) == 'a' || input1.ElementAt(i) == 'A' || input1.ElementAt(i) == 'e' ||
                        input1.ElementAt(i) == 'E' || input1.ElementAt(i) == 'i' || input1.ElementAt(i) == 'I' ||
                        input1.ElementAt(i) == 'o' || input1.ElementAt(i) == 'O' || input1.ElementAt(i) == 'u' || input1.ElementAt(i) == 'U')
                        concat = concat + input1.ElementAt(i);
                }
            }

            if (input3 == 0)
                result=concat.ToLower();
            else if (input3 == 1)
                result=concat.ToUpper();

            return result;
        }

        static void Main()
        {
            Console.WriteLine(ExtractVowelsNonVowels(Console.ReadLine(),Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
        }
    }
}
