public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> newDict =
            new Dictionary<char, char> { { ')', '(' }, { ']', '[' }, { '}', '{' } };
        foreach (char c in s) {
            if (newDict.ContainsKey(c)) {
                if (stack.Count > 0 && stack.Peek() == newDict[c]) {
                    stack.Pop();
                } else {
                    return false;
                }
            } else {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}