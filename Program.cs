using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> MyStack = new Stack<string>();
            GetInputString(MyStack);
            Console.ReadKey();

        }
        public static void GetInputString(Stack<string> MyStack)
        {
            string input;
            Console.WriteLine("Stack operations" + "1.push" +" "+ "2.pop" +" "+ "3.greatest number in stack"+" "+"4.exit");

         
                input = Console.ReadLine();
            bool validIP = CheckInput(input);
            if (validIP == false)
            {
                Console.WriteLine("enter a valid option");
            }
            else
            {

                if (input == "1")
                {
                    Console.WriteLine("enter the number to push");
                    string pushnumber = Console.ReadLine();
                    MyStack = PushStack(pushnumber, MyStack);

                    GetInputString(MyStack);

                }
                if (input == "2")
                {
                    MyStack = PopStack(MyStack);
                    GetInputString(MyStack);
                }
                if (input == "3")
                {
                    MyStack = MaxNumber(MyStack);
                    GetInputString(MyStack);
                }
                if (input == "4")
                    return;
            }
        }

        public static Stack<string> PushStack(string number,Stack<string> newstack)
        {
            
            newstack.Push(number);
            return newstack;
        }
        public static bool CheckInput(string input)
        {
            if (input == "1" || input == "2" || input == "3" || input == "4")
                return true;
            else
                return false;
        }

        public static Stack<string> PopStack(Stack<string> Mystack)
        {
            Console.WriteLine("the poped element was" + Mystack.Pop());
            return Mystack;
        }
        public static Stack<string> MaxNumber(Stack<string> NewStack)
        {
            int? max = null;
            int? value = null;
            foreach(var imt in NewStack)
            {
                value = Convert.ToInt32(imt);
                if(max==null)
                {
                    max = value;
                }
                else
                {
                    if(value>max)
                    {
                        max = value;
                    }
                }

            }
            Console.WriteLine("largest number in stack is:" + max);
            return NewStack;
        }
       
    }
}
