public class Solution
{
    public string IntToRoman(int num)
    {
        string ans = "";

        int romCount = 0;

        while (num > 0)
        {
            if (num >= 1000)
            {
                romCount = num / 1000;
                ans = AppendRoman(ans, romCount, "M");
                num -= (romCount * 1000);
            }

            if (num >= 900)
            {
                romCount = num / 900;
                ans = AppendRoman(ans, romCount, "CM");
                num -= (romCount * 900);
            }

            if (num >= 500)
            {
                romCount = num / 500;
                ans = AppendRoman(ans, romCount, "D");
                num -= (romCount * 500);
            }

            if (num >= 400)
            {
                romCount = num / 400;
                ans = AppendRoman(ans, romCount, "CD");
                num -= (romCount * 400);
            }

            if (num >= 100)
            {
                romCount = num / 100;
                ans = AppendRoman(ans, romCount, "C");
                num -= (romCount * 100);
            }

            if (num >= 90)
            {
                romCount = num / 90;
                ans = AppendRoman(ans, romCount, "XC");
                num -= (romCount * 90);
            }

            if (num >= 50)
            {
                romCount = num / 50;
                ans = AppendRoman(ans, romCount, "L");
                num -= (romCount * 50);
            }

            if (num >= 40)
            {
                romCount = num / 40;
                ans = AppendRoman(ans, romCount, "XL");
                num -= (romCount * 40);
            }

            if (num >= 10)
            {
                romCount = num / 10;
                ans = AppendRoman(ans, romCount, "X");
                num -= (romCount * 10);
            }

            if (num >= 9)
            {
                romCount = num / 9;
                ans = AppendRoman(ans, romCount, "IX");
                num -= (romCount * 9);
            }

            if (num >= 5)
            {
                romCount = num / 5;
                ans = AppendRoman(ans, romCount, "V");
                num -= (romCount * 5);
            }

            if (num >= 4)
            {
                romCount = num / 4;
                ans = AppendRoman(ans, romCount, "IV");
                num -= (romCount * 4);
            }

            if (num >= 1)
            {
                romCount = num / 1;
                ans = AppendRoman(ans, romCount, "I");
                num -= (romCount * 1);
            }
        }

        return ans;
    }

    public string AppendRoman(string ans, int romCount, string romNum)
    {
        while (romCount != 0)
        {
            ans += romNum;
            romCount--;
        }

        return ans;
    }
}