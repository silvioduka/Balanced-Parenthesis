/*
Balanced Parenthesis - Easy from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-08

Create a program that checks if in a given string expression all the parenthesis are balanced. 
For Example: 
(test) - valid 
(no() - invalid 
()(()) - valid 
(123(456)(7))( - invalid 
(val()id) - valid 

Also, take into account the "\" escape sequences: 
(nope\) - invalid 
(v\(al) - valid 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParenthesis
{
    class Program
    {
        static string input = @"(123(456)(7))(v\(al)"; // Insert here a string to check if all the parenthesis are balanced

        static void Main(string[] args)
        {
            int p = 0;
            char o = ' ';

            foreach (char c in input)
            {
                if (c == '(' && o != '\\') { p++; continue; }
                if (c == ')' && o != '\\') { p--; continue; }

                o = c;
            }

            Console.WriteLine($"Input string: {input}\nParenthesis {((p==0)?"are":"are NOT")} balanced!");
        }
    }
}