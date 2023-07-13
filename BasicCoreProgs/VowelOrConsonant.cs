using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects
{
    public class VowelOrConsonant
    {
        public void isVowel(char charValue)
        {
            char[] vowelList = { 'a', 'e', 'i', 'o', 'u' };

            char casedChar = char.ToLower(charValue);//handle simple and capital vowels

            for (int i = 0; i < vowelList.Length; i++)
            {
                if (vowelList[i] == casedChar)
                {
                    Console.WriteLine("Vowel");
                    break;
                }
                else
                {
                    Console.WriteLine("Consonant");
                    break;
                }

            }




        }
    }
}
