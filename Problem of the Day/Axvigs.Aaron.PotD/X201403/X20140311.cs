using System;
using System.Collections.Generic;
using System.Text;

namespace Axvigs.Aaron.PotD.X201403
{
    public static class X20140311
    {
        public static bool IsPalindrome(int number)
        {
            List<int> components = new List<int>();

            int remainder = 0;
            int counter = 0;

            // Put the digits into a list.
            while (Math.Pow(10, counter) < number)
            {
                number -= remainder;
                remainder = (int)(number % (Math.Pow(10, counter + 1)));
                components.Add((int)(remainder / Math.Pow(10, counter)));
                counter++;
            }

            // Check if the list is a palindrome.
            for (int i = 0; i < (int) (Math.Floor((double) (components.Count / 2))); i++)
            {
                if(components[i] != components[components.Count - 1 - i])
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}