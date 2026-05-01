public class Solution {
    public bool IsValid(string s) {
        Stack<char> c = new Stack<char>();

        for (int i = 0; i < s.Length; i++) {
            char current = s[i];
            if (current == '[' || current == '(' || current == '{') {
                c.Push(current);
            }
            else {
                if (c.Count == 0) {
                    return false;
                }
                
                char top = c.Pop();

                if ((current == ')' && top != '(') || 
                    (current == ']' && top != '[') || 
                    (current == '}' && top != '{')) {
                    return false;
                }
            }
        }

        return c.Count == 0;
    }
}