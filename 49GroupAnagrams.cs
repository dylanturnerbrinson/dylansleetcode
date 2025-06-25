//Given an array of strings strs, group the together. You can return the answer in any order.

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        //verify both strings contain the same characters 
        //not necessarily in any order

        IList<IList<string>> matrix = new List<IList<string>>();

        //Scan for null entries. If 1 is found, put it in its own array. If two are found, put them in a list together. Remove the rest.

        if (strs.Contains(""))
        {
            //Console.WriteLine("Found null");
            IList<string> nullagrams = new List<string>();
            foreach (string str in strs)
            {
                if (str == "")
                {
                    nullagrams.Add(str);
                }
            }

            matrix.Add(nullagrams);
        }

        //if the sampled word contains the same letters and is the same length, then it is an anagram.
        for (int i = 0; i < strs.Length; i++)
        {
            string word = strs[i];
            bool breakloop = false;
            foreach (List<string> a in matrix)
            {
                //Console.WriteLine($"Checking if {a.ToString()} contains {word}");

                foreach (string b in a)
                {
                    //Console.WriteLine($"Comparing {b} vs {a}");

                    if (b == word)
                    {
                        breakloop = true;
                    }
                }
            }

            if (breakloop)
            {
                continue;
            }

            //sort the word alphabetically
            /* the comparison works by sorting word with a sample word in the array.
            both words are sorted alphabetically. if they are identical, they are anagrams
            */

            char[] temp_word = word.ToArray();
            Array.Sort(temp_word);

            IList<string> anagrams = new List<string>();

            //Console.WriteLine($"ADDING WORD {word}");
            anagrams.Add(word);

            for (int q = i + 1; q < strs.Length; q++)
            {
                string sample_word = strs[q];

                //If the word is the same, or the word is a different length, its not an anagram
                if (sample_word.Length != word.Length)
                {
                    continue;
                }

                //Sort word and sample word alphabetically. Then compare their elements. If each element is the same, is
                //anagram!

                char[] temp_sample = sample_word.ToArray();
                Array.Sort(temp_sample);

                bool match = false;

                for (int z = 0; z < temp_word.Length; z++)
                {
                    char letter = temp_word[z];

                    if (letter != temp_sample[z])
                    {
                        match = false;
                        break;
                    }
                    else
                    {
                        match = true;
                    }
                }

                if (match == true)
                {
                    anagrams.Add(sample_word);
                }
            }
            matrix.Add(anagrams);
        }
        return matrix;
    }
}