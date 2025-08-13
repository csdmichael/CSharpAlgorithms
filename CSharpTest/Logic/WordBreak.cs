using System;
using System.Collections.Generic;

public class WordBreak{
    public void wordBreak(List<string> dict, string word, string output) {
        if (String.IsNullOrEmpty(word)) {
            Console.WriteLine(output);
        }
        for (int i = 0; i < word.Length; i++) {
            string prefix = word.Substring(0, i + 1);
            if (dict.Contains(prefix)) {
                string res = output + " " + prefix;
                wordBreak(dict, word.Substring(i+1), res);
            }
        }
    }
}