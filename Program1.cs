using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversestring
{
    public class Program
    {
        static void Main(string[] args)
        {
            string InputString = GetInputString(args);
            string revstr = Revwithstack(InputString);
            Console.WriteLine("1st approach result" + " " + revstr);
            string revstr1 = ReverseString(InputString);
            Console.WriteLine("2nd approach result" + " " + revstr1);
            string revstr2 = ReverseNostack(InputString);
            Console.WriteLine("3rd approach result" + " " + revstr2);


            Console.ReadLine();
        }

        public static string GetInputString(string[] args)
        {
            string input;

            if (args.Any())
                input = args[0];
            else
                {
                Console.WriteLine("Input Any String");
                input = Console.ReadLine();
                }
            return input;
        }



        public static string Revwithstack(string str)
        {
            string revstr = null;
            Stack<char> mystack = new Stack<char>();
            foreach (var i in str)
                mystack.Push(i);

            foreach (var ix in mystack)
              revstr += ix;
            return revstr;
            
        }

        public  static string ReverseString(string str1)
        {
            string revstr = null;
            Stack<char> newstack = new Stack<char>();
            for(int i=0;i<str1.Length;i++)
            {
                newstack.Push(str1[i]);
            }
            for(int i=0;i<str1.Length;i++)
            {
                revstr += newstack.Pop();
            }
            return revstr;            
        }

        public static string ReverseNostack(string str2)
        {
            string reversestr = null;           
           
           int count = str2.Length-1;
           for(int i=count;i >= 0 ;i--)
           {               
               reversestr += str2[i];                            

           }
            return reversestr;            
        }
    }
}
