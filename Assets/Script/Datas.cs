using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Datas
{
    public static char[] RandomLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
    public static string ExtractLetters()
    {
        StringBuilder temp = new StringBuilder();
        System.Random random = new System.Random();
        for (int i = 0; i < 16; i++)
        {
            temp.Append(RandomLetters[random.Next(RandomLetters.Length)]);
        }
        return temp.ToString();
    }
    public static Dictionary<string, Character> Characters = new Dictionary<string, Character>()
    {
        {"Player", new Character()}
    };
}
