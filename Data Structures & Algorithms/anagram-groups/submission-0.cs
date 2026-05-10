public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> sortedStrings = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            string sortedStr = new string(s.OrderBy(x => x).ToArray());
            if (sortedStrings.ContainsKey(sortedStr)) {
                sortedStrings[sortedStr].Add(s);
            } else {
                sortedStrings[sortedStr] = new List<string> { s };
            }
        }
        return sortedStrings.Select(x => x.Value).ToList();
    }
}
