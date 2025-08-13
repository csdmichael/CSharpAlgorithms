using System.Text.RegularExpressions;

public class ValidPaligromeE{
    public bool IsValidPaligrome(string s) {
        if (s == null) return true;
        if (s.Length <= 1) return true;
        s = Regex.Replace(s, "[^a-zA-Z0-9]", String.Empty);
        s = s.ToLower();
        int ptr1 = 0, ptr2 = s.Length - 1;
        while (ptr1 < ptr2) {
            if (s[ptr1] == s[ptr2]) {
                ptr1++; ptr2--;
            }
            else return false;
        }
        return true;
    } 
}

/*
    ab,c ba

    1) Regular Expr to remove anything from string but a-zA-Z0-9

    abcba

    2) 2 ptrs (ptr1 = 0, ptr2 = s.Length - 1)

````ptr1 2
    ptr2 2

    Time: O(n)
    Space: O(1)

*/