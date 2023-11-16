namespace Tumakov
{
    interface ICipher
    {
        string encode(string str);
        string decode(string str);
    }
}
