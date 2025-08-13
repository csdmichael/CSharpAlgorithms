public class LongestPalindrome
{
    public static string GetLongestPlaindrome(string s)
    {
        string res = "";
        int maxLen = 0;
        if (s.Length <= 2) return s;
        
        for (int i = 0; i < s.Length; i++)
        {
            //Handle odd pattern
            int left = i, right = i;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                int len = right - left + 1;
                if (len > maxLen)
                {
                    maxLen = len;
                    res = s.Substring(left, len);
                }
                left--;
                right++;
            }

            //Handle even pattern
            left = i; right = i + 1;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                int len = right - left + 1;
                if (len > maxLen)
                {
                    maxLen = len;
                    res = s.Substring(left, len);
                }
                left--;
                right++;
            }
        }

        return res;
    }
}