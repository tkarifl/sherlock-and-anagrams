	    public static List<string> substring_factory(string input)
        {
            List<string> sortedSubstringList = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    var substring = input.Substring(i, j - i + 1);
                    var char_array = substring.ToCharArray();
                    Array.Sort(char_array);
                    sortedSubstringList.Add(new string(char_array));
                }
            }
            return sortedSubstringList;
        }

        public static int sherlockAndAnagrams(string s)
        {
            int anagram_count = 0;
            List<string> substringList = substring_factory(s);
            int substringListCount = substringList.Count;
            for (int i = 0; i < substringListCount; i++)
            {
                for (int j = i; j < substringListCount; j++)
                {

                    if (i == j || substringList[i].Length != substringList[j].Length)
                        continue;

                    else if (String.Equals(substringList[i], substringList[j]))
                        anagram_count++;
                }
            }
            return anagram_count;
        }