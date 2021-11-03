using System;

namespace Open_Lab_03._06
{
    public class Checker
    {
        public bool HasSpaces(string str)
        {
            
            bool fHasSpace = str.Contains(" ");
            return fHasSpace;

        }
    }
}
