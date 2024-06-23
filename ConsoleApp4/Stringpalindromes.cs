using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  public class Stringpalindromes
    {     
            
    

       public  bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
             foreach (char c in str) {
                if (char.IsLetterOrDigit(c)) { 
                sb1.Append(char.ToLower(c));
                }
            }
            for (int i = sb1.Length - 1; i >= 0; i--)
            {
                sb2.Append(sb1[i]);
            }
            if (sb1.ToString() == sb2.ToString())
            {
                return true;
            }
            else { return false; }

            //while (left < right)
            //{
                
            //    // Skip non-alphanumeric characters
            //    while (left < right && !char.IsLetterOrDigit(str[left]))
            //    {
            //        left++;
            //    }
            //    while (left < right && !char.IsLetterOrDigit(str[right]))
            //    {
            //        right--;
            //    }

            //    if (char.ToLower(str[left]) != char.ToLower(str[right]))
            //    {
            //        return false;
            //    }

            //    left++;
            //    right--;
            //}

            //return true;
        }
    }

}
