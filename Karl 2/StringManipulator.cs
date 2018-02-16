using System;

namespace Karl_2
{
    public class StringManipulator
    {
        public string PlusOne(string Name)
        {
            return Name + "_One";
        }
        public string ReverseString(string sutString)
        {
            char[] inputarray = sutString.ToCharArray();
            Array.Reverse(inputarray);
            string output = new string(inputarray);
            return output;
        }
    }
}
