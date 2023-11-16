using System;
using System.Linq;

namespace Tumakov
{
    class BCipher : ICipher
    {
        public string encode(string str)
        {
            char[] chars = str.ToCharArray();
            string letters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string littlLetters = letters.ToLower();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    char baseEngChar = char.IsUpper(chars[i]) ? 'A' : 'a';
                    if ((chars[i] >= 'A' && chars[i] <= 'Z') || (chars[i] >= 'a' && chars[i] <= 'z'))
                        chars[i] = (char)(baseEngChar + ('Z' - chars[i]));
                    else if (char.IsLower(chars[i]))
                        chars[i] = littlLetters[32 - littlLetters.IndexOf(chars[i])];   
                    else
                        chars[i] = letters[32 - letters.IndexOf(chars[i])];
                }         
                else
                    return "Исходная строка содержит символы, не входящие в алфавит!";
            }
            return new string(chars);
        }
        public string decode(string str)
        {
            return encode(str);
        }
    }
}
