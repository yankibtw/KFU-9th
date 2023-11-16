namespace Tumakov
{
    class ACipher : ICipher
    {
        public string encode(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (chars[i] != 'z' & chars[i] != 'Z' & chars[i] != 'я' & chars[i] != 'Я')
                    {
                        chars[i] = (char)(chars[i] + 1);
                    }
                    else if (char.IsLower(str[i]) & chars[i] != 'z')
                    {
                        chars[i] = 'а';
                    }
                    else if (char.IsUpper(str[i]) & chars[i] != 'Z')
                    {
                        chars[i] = 'А';
                    }
                    else if (char.IsLower(str[i]))
                    {
                        chars[i] = 'a';
                    }
                    else
                    {
                        chars[i] = 'A';
                    }
                }
                else
                {
                    return "Исходная строка содержит символы, не входящие в алфавит!";
                }
            }
            return new string(chars);
        }
        public string decode(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (chars[i] != 'a' & chars[i] != 'A' & chars[i] != 'а' & chars[i] != 'А')
                    {
                        chars[i] = (char)(chars[i] - 1);
                    }
                    else if (char.IsLower(str[i]) & chars[i] != 'a')
                    {
                        chars[i] = 'я';
                    }
                    else if (char.IsUpper(str[i]) & chars[i] != 'A')
                    {
                        chars[i] = 'Я';
                    }
                    else if (char.IsLower(str[i]))
                    {
                        chars[i] = 'z';
                    }
                    else
                    {
                        chars[i] = 'Z';
                    }
                }
                else
                {
                    return "Исходная строка содержит символы, не входящие в алфавит!";
                }             
            }
            return new string(chars);
        }
    }
}
