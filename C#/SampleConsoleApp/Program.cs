using System;
using System.Linq;
namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Start here.....");
            //string test = reverseString("hello");

            string result = ConvertToTitle(2000);


            Console.WriteLine("Program Ends here.....");
        }

        static string ConvertToTitle(int n) {
            string result="";
            char [] letters = {'A','B', 'C','D', 'E','F', 'G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            
            while(n > 26)
            {   
                int reminder = n % 26;
                result = result + Convert.ToString(letters[reminder-1]);
                int diviser = n / 26;                
                n = diviser;
            }
            result = result + Convert.ToString(letters[n - 1]);
            char[] charArray = result.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static string reverseString(string str)
        {
            var strarr = str.Reverse();
            
            foreach (char item in strarr)
            {
                str = item + str;
            }

            //char[] str1 = str.ToCharArray();
            //str = "";
            //foreach (char ch in str1)
            //{
            //    str = ch + str;
            //}

            return str;
        }
    }
}
