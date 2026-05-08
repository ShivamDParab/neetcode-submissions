public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        string newStrS = new string(s.OrderBy(c=>c).ToArray());
        string newStrT = new string(t.OrderBy(c=>c).ToArray());
        if (string.Equals(newStrS,newStrT)) return true;
        return false;
    }
}
