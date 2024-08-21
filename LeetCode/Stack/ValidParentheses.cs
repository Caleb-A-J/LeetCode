using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            // Create a stack to store opening parentheses
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                // Check if the current character is an opening parenthesis
                if (c == '(' || c == '{' || c == '[')
                {
                    // Push the opening parenthesis onto the stack
                    stack.Push(c);
                }
                else
                {
                    // Check if the current character is a closing parenthesis
                    // and if the stack is empty
                    if (stack.Count == 0)
                    {
                        // If the stack is empty, there's no corresponding opening parenthesis
                        return false;
                    }

                    // Pop the top element of the stack to check if it matches the closing parenthesis
                    char top = stack.Pop();
                    if ((top == '(' && c != ')') ||
                        (top == '{' && c != '}') ||
                        (top == '[' && c != ']'))
                    {
                        // If the top element doesn't match the closing parenthesis, the parentheses are not balanced
                        return false;
                    }
                }
            }

            // If the stack is empty at the end, all parentheses are balanced
            return stack.Count == 0;
        }
    }
}
