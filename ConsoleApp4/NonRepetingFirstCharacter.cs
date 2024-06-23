using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class NonRepetingFirstCharacter
    {
        public char GetnonrepetingFirstCharacter( string input)
        {
            string output="";
             Dictionary<char ,int> charcount= new Dictionary<char ,int>();

            foreach(char c in input) 
            {
            if (charcount.ContainsKey(c))
             {
                charcount[c]++;
             }
            else 
                { charcount[c] = 1; }
            }

            foreach (char c in input)
            {
            if (charcount[c] == 1) { return c; }
            }

            return '\0';
        }
    }
}
