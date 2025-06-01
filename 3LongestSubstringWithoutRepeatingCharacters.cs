public class Solution {
    public int LengthOfLongestSubstring(string s) {
        char[] s_arr = s.ToCharArray();
        List<char> s_list = s_arr.ToList();
        List<char> s_work = s_arr.ToList();
        List<char> temp_list = new List<char>();
        List<int> substring_lengths = new List<int>();
        List<List<char>> substrings = new List<List<char>>();
        
        int substring_length = 0;
        substring_lengths.Add(substring_length);

        if (!string.IsNullOrEmpty(s)){
            foreach (char q in s_list){
                //foreach character, find all of the lengths of their substrings
                //  if 
                for(int i = 0; i < s_work.Count; i++){
                    char c = s_work[i];
                    if (!temp_list.Contains(c)){
                        substring_length++;
                        temp_list.Add(c);
                    } else {
                        break;
                    }
                }

                substring_lengths.Add(substring_length);

                if (!substrings.Contains(temp_list)){
                    substrings.Add(temp_list);
                }

                temp_list.Clear();
                substring_length = 0;
                s_work.Remove(q);
            }
        }

        //substring_lengths.Add(substring_length);
        return substring_lengths.Max();
    }
}