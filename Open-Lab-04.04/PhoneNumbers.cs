using System;
using System.Security.Principal;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
            char[] first = new char[3];
            char[] second = new char[3];
            char[] third = new char[4];
            for (int o = 0; o < 3; o++)
            {
                char charnow = Convert.ToChar(numbers[o]+48);
                first[o] = charnow;
            }
            for (int o = 0; o < 3; o++)
            {
                char charnow = Convert.ToChar(numbers[o+3]+48);
                second[o] = charnow;
            }
            for (int o = 0; o < 4; o++)
            {
                char charnow = Convert.ToChar(numbers[o+6]+48);
                third[o] = charnow;
            }
            string firsti = new string(first);
            string secondi = new string(second);
            string thirdi = new string(third);
            string pepega = ("(" + firsti + ") " + secondi + "-" + thirdi);
            return pepega;

        }
    }
}
