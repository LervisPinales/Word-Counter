public class Lunestdd
{
    // public string tword;
    public Lunestdd(string text)
    {

    }


    public int ContadorText()
    {
        string str = (" Same bed but it feels just a little bit bigger now Our song on the radio but it don't sound the same");
        int words, A;
        A = 0;
        words = 1;
        while (A <= str.Length - 1)
        {

            if (str[A] == ' ' || str[A] == '\n' || str[A] == '\t')
            {
                words++;
            }

            A++;
        }
        return words;

    }


}

