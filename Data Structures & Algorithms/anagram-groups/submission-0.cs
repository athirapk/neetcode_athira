public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        foreach (string str in strs)
        {
            char[] characters = str.ToCharArray();
            Array.Sort(characters);
            string key = new string(characters);
            if (!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(str);
        }

        return map.Values.ToList<List<string>>();
    }
}
