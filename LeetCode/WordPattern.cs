using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class WordPatterns
    {
            public static bool WordPattern(string pattern, string s)
    {
        // Create dictionaries to map characters to words and vice versa
        var charToWord = new Dictionary<char, string>();
        var wordToChar = new Dictionary<string, char>();

        // Split the string into words
        var words = s.Split(' ');

        // Check if the lengths of the pattern and words array match
        if (pattern.Length != words.Length)
        {
            return false;
        }

        for (int i = 0; i < pattern.Length; i++)
        {
            char c = pattern[i];
            string word = words[i];

            // Check if the character-word mapping exists and is consistent
            if (charToWord.ContainsKey(c))
            {
                if (charToWord[c] != word)
                {
                    return false;
                }
            }
            else if (wordToChar.ContainsKey(word))
            {
                if (wordToChar[word] != c)
                {
                    return false;
                }
            }
            else
            {
                // Create new mappings if they don't exist
                charToWord[c] = word;
                wordToChar[word] = c;
            }
        }

        return true;
    }
    }
}
