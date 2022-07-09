public class Solution
{
    public bool IsPalindrome(int x)
    {
        bool isPalindrome = true;
        string number = x.ToString();
        char[] chars = number.ToCharArray();
        for (int i = 0;i<= (chars.Length/2)+1; i++)
        {
            if(i < chars.Length && chars[i] != chars[chars.Length-i-1]) isPalindrome=false;
        }
        return isPalindrome;

    }
}
