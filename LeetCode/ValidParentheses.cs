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
            // Create a stack to store opening brackets
            Stack<char> stack = new Stack<char>();

            // Iterate through each character in the string
            foreach (char c in s)
            {
                // If it's an opening bracket, push it onto the stack
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                // If it's a closing bracket, check if the stack is empty
                // or if the top element doesn't match the corresponding opening bracket
                else if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), c))
                {
                    return false;
                }
            }

            // If the stack is empty at the end, the string is valid
            return stack.Count == 0;
        }

        static bool IsMatchingPair(char opening, char closing)
        {
            // Check if the opening and closing brackets match
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']');
        }
    }
}
