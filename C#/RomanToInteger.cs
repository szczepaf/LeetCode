public class Solution
{
    public int RomanToInt(string s)
    {
        int integer = 0;
        if (s.Contains("IV")){
            integer += 4;
            s = s.Replace("IV", "");
        }
        if (s.Contains("IX"))
        {
            integer += 9;
            s = s.Replace("IX", "");

        }
        if (s.Contains("XL"))
        {
            integer += 40;
            s = s.Replace("XL", "");

        }
        if (s.Contains("XC"))
        {
            integer += 90;
            s = s.Replace("XC", "");

        }
        if (s.Contains("CD"))
        {
            integer += 400;
            s = s.Replace("CD", "");

        }
        if (s.Contains("CM"))
        {
            integer += 900;
            s = s.Replace("CM", "");

        }


        int i = 0;

        while(i < s.Length && s[i] == 'M')
        {
            i++;
            integer += 1000;
        }
        while (i < s.Length && s[i] == 'D')
        {
            i++;
            integer += 500;
        }
        while (i < s.Length && s[i] == 'C')
        {
            i++;
            integer += 100;
        }
        while (i < s.Length && s[i] == 'L')
        {
            i++;
            integer += 50;
        }
        while (i < s.Length && s[i] == 'X')
        {
            i++;
            integer += 10;
        }
        while (i < s.Length && s[i] == 'V')
        {
            i++;
            integer += 5;
        }
        while (i < s.Length && s[i] == 'I')
        {
            i++;
            integer += 1;
        }


        return integer;
    }
}
