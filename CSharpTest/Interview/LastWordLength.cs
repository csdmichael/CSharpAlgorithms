public class LastWordLength {
    public int LengthOfLastWord(string s) {
        string[] words = s.Split(' ');
        string lastWord = "";
        int i = words.Length-1; 
        while (i >= 0) {
            if (words[i].Trim().Length > 0) {
                lastWord = words[i];
                break;
            }
            else
                i--;
        }
        if (i >= 0) {
            return lastWord.Length;
        }
        else
            return -1;
    }
}