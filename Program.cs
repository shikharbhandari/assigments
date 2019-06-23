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
            string input;           
            while (true)
            {
                Getinput obj = new Getinput();
                input =obj.Getuserinput();
                MyStackclass mystack = new MyStackclass();
                
                //Program obj = new Program();
                switch(input)
                {
                    case "1" :
                        {
                            Console.WriteLine("enter the number to push");
                            string pushnumber = Console.ReadLine();

                            MyStack = MyStackclass.Push(MyStack,pushnumber);
                        }
                        break;
                    case "2" :
                        MyStack = MyStackclass.Pop(MyStack);
                        break;
                    case "3" :
                        var newstack = MyStackclass.MaxNumber(MyStack);
                        break;
                    case "4":
                        return;                        
                    default :
                        Console.WriteLine("enter the valid input");
                        break;
                }
            }
        }            
    }      
    
    public class MyStackclass
    {
        public static Stack<string> Push(Stack<string> Newstack,string pushnumber)
        {
            bool result1 = int.TryParse(pushnumber, out int result);
            if (result1 == true)
            {
                Newstack.Push(pushnumber);
                return Newstack;
            }
            else
            {
                Console.WriteLine("enter a number");
                return Newstack;
            }

        }

        public static Stack<string> MaxNumber(Stack<string> NewStack)
        {
            int? max = null;
            int? value = null;
            foreach (var imt in NewStack)
            {
                value = Convert.ToInt32(imt);
                if (max == null)
                {
                    max = value;
                }
                else if (value > max)
                {
                    max = value;

                }

            }
            //max = Convert.ToInt32(NewStack.Max());
            if (NewStack.Count < 1)
            {
                Console.WriteLine("there is no element in the stack");
                return NewStack;
            }
            else
            {
                Console.WriteLine("largest number in stack is:" + max);
                return NewStack;
            }
        }

        public static Stack<string> Pop(Stack<string> Newstack)
        {
            if (Newstack.Count < 1)
            {
                Console.WriteLine("there is no element to pop");
                return Newstack;
            }
            else
            {
                Console.WriteLine("the poped element was" + Newstack.Pop());
                return Newstack;
            }
        }
     
    }
    public class Getinput
    {
        public string Getuserinput()
        {
            string input=string.Empty;
            Console.WriteLine("Stack operations" + "1.push" + " " + "2.pop" + " " + "3.greatest number in stack" + " " + "4.exit");
            input=Console.ReadLine();
            return input;

        }
    }

}
