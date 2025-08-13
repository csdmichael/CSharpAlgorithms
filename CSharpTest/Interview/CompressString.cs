public class CompressString {
    public int Compress(char[] chars) {
        if (chars == null) return 0; //or -1
        if (chars.Length <= 1) return chars.Length;
        int p1 = 0;
        int p2 = p1+1;
        string res = "";
        while (p2 < chars.Length) {
            char c1 = chars[p1];
            char c2 = chars[p2];
            if (p2 == chars.Length - 1) {
                int count = p2-p1+1;
                if (c1 == c2) {
                    res+= c1.ToString() + count;
                }
                else {
                    
                    res+= c1.ToString() + ((count > 1)?count:"") + c2.ToString();
                }
                
                p2++;
            } 
            else if (c1 == c2) {
                p2++;
            }   
            else {
                int count = p2-p1;
                string cnt = (count > 1)?count.ToString():"";
                res += c1.ToString() + cnt;
                p1 = p2;
                p2++;
            }
        }
        for(int i = 0; i < res.Length; i++) {
            chars[i] = res[i];
        }
        

        return res.Length;
    }
}

/*
aa

a,a,b,b,c,c,c

p1 = 0
p2 = 1->2=
compressed = a2

p1 = 2
p2 = 3->4
compressed = a2b2


*/