public class BinaryAdd {
    public string AddBinary(string a, string b) {
        string res = "";
        int p1 = a.Length - 1, p2 = b.Length - 1;
        bool isReminder = false;
        while(p1 >= 0 || p2 >= 0) {
            if (p1 < 0) {
                if (!isReminder) {
                   res = b[p2] + res;
                }
                else {
                   if (b[p2] == '1') {
                       res = "0" + res;
                       isReminder = true;
                   }
                   else {
                       res = "1" + res;
                       isReminder = false;
                   }
                }
                p2--;
            }
            else if (p2 < 0) {
                if (!isReminder) {
                   res = a[p1] + res;
                }
                else {
                   if (a[p1] == '1') {
                       res = "0" + res;
                       isReminder = true;
                   }
                   else {
                       res = "1" + res;
                       isReminder = false;
                   }
                }
                p1--;
            }
            else {
                if (a[p1] == '1' && b[p2] == '1') {
                    if (isReminder) {
                        res = "1" + res;
                        isReminder = true;
                    }
                    else {
                        res = "0" + res;
                        isReminder = true;
                    }
                }
                else if (a[p1] == '1' || b[p2] == '1') {
                    if (isReminder) {
                        res = "0" + res;
                        isReminder = true;
                    }
                    else {
                        res = "1" + res;
                    }
                    
                }
                else {
                    if (isReminder) {
                        res = "1" + res;
                        isReminder = false;
                    }
                    else {
                        res = "0" + res;
                    }
                    
                }
                p1--;
                p2--;
            }
        }
        if (isReminder) {
            res = "1" + res;
        }
        return res;
    }
}

/*
Given two binary strings a and b, return their sum as a binary string.

 

Example 1:

Input: a = "11", b = "1"
Output: "100"
Example 2:

Input: a = "1010", b = "1011"
Output: "10101"
 

Constraints:

1 <= a.length, b.length <= 104
a and b consist only of '0' or '1' characters.
Each string does not contain leading zeros except for the zero itself.
*/