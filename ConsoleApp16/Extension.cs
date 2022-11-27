using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    static class Extension
    {
        public static bool CustomContain(this string sentence, string search)
        {

            if (search.Equals(sentence) || search.Equals(sentence.ToLower()))
            {
                return true;
            }

            string[] SentenceArr = sentence.Split();

            foreach (string word in SentenceArr)
            {
                if (search.Equals(word) || search.Equals(word.ToLower()))
                {
                    return true;
                }
                else if (word.EndsWith(search) || word.StartsWith(search))
                {
                    return true;
                }
            }
            return false;
        }   
    }
}
