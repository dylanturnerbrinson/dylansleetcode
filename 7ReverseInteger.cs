//Reverse integer

public class Solution
{
    public int Reverse(int x)
    {
        bool neg = x < 0;

        if (neg)
        {
            x = x * -1;
        }

        string strX = x.ToString();

        if (neg)
        {
            strX += "-";
        }

        char[] charX = strX.ToArray();

        Array.Reverse(charX);

        strX = string.Join("", charX);

        int ans = 0;

        //Console.WriteLine($"reversed int : {strX}");

        Int32.TryParse(strX, out ans);

        return ans;
    }
}