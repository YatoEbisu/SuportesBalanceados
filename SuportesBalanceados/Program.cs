using System;
using System.Linq;

namespace SuportesBalanceados
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public bool ValidString(string str)
        {
            var str1 = str.ToArray();
            var str2 = str.ToArray();

            if (str1.Length % 2 == 0)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] == '[' || str1[i] == '(' || str1[i] == '{')
                    {
                        switch (str1[i])
                        {
                            case '[':
                                for (int l = 0; l < str2.Length; l++)
                                {
                                    if (str2[l] == ']')
                                    {
                                        str2 = str2.Where((source, index) => index != 0 && index != l).ToArray();
                                        break;
                                    }
                                }
                                break;
                            case '(':
                                for (int l = 0; l < str2.Length; l++)
                                {
                                    if (str2[l] == ')')
                                    {
                                        str2 = str2.Where((source, index) => index != 0 && index != l).ToArray();
                                        break;
                                    }
                                }
                                break;
                            case '{':
                                for (int l = 0; l < str2.Length; l++)
                                {
                                    if (str2[l] == '}')
                                    {
                                        str2 = str2.Where((source, index) => index != 0 && index != l).ToArray();
                                        break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (str2.Length > 0)
                    return false; //Console.WriteLine("Não Valido");
                else
                    return true;//Console.WriteLine("Valido");
            }
            else
                return false; // Console.WriteLine("Não Valido");
        }
    }

}
