class Solution {
    public boolean isValid(String s) {
        Stack<Character> cStack = new Stack<>();

        for (char c : s.toCharArray()) {
            if (c == '[' || c == '{' || c == '(') {
                cStack.push(c);
            } else {
                // If it's a closing bracket and the stack is empty, it's invalid
                if (cStack.empty()) {
                    return false;
                }
                
                // Now check if it matches the top of the stack
                if (c == ']' && cStack.peek() == '[' || 
                    c == '}' && cStack.peek() == '{' || 
                    c == ')' && cStack.peek() == '(') {
                    cStack.pop();
                } else {
                    return false;
                }
            }
        }
        return cStack.empty();
    }
}
