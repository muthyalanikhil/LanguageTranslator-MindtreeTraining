using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageTranslator
{
    class Translator
    {
        public void logic()
        {
            try
            {
                char[] A = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', ' ' };
                char[] B = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ' };
                string str;
                Console.WriteLine("Enter the statement to be converted");
                str = Console.ReadLine();

                for (int j = 0; j < str.Length; j++)
                {
                    for (int k = 0; k < 27; k++)
                    {
                        if (str[j] == A[k])
                        {
                            Console.Write(B[k]);
                        }
                    }
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
