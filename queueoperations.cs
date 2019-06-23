using System;
using System.Collections.Generic;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queueoperations
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0;
            Makequeue obj = new Makequeue();
            Timerequired obj1 = new Timerequired();
            Getinput getinputfromuser = new Getinput();
            int input = getinputfromuser.Gettotaltest();
            do
            {               
                var data = getinputfromuser.Gettotaljobsandposition();
                int p = int.Parse(data[0]);
                int q = Convert.ToInt32(data[1]);
                
                if (p > 0 && p < 100 && p > q)
                {

                    string priority = getinputfromuser.Getpriority();
                    int noofpriority = getinputfromuser.Checkpriority(priority);
                    if ( noofpriority == p)
                    {
                        Queue<int> prique = obj.Priorityqueue(priority);
                        Queue<string> refque = obj.Referencequeue(p, q);
                        int count = obj1.Timetaken(prique, refque, q);
                        Console.WriteLine("time taken:" + count);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("enter the priorities properly");
                    }
                }
                else
                {
                    Console.WriteLine("stand in the queue");
                }
                
            } while (i<input);

            Console.ReadLine();
        }
    }
    
    public class Getinput
    {
        public String Getpriority()
        {

            Console.WriteLine("enter the priorities");
            var priority = Console.ReadLine();
            return priority;
        }
        public int Checkpriority(string priority)
        {
            var data1 = priority.Split(' ');
            int noofpriority = data1.Count();
            return noofpriority;
        }

        public string[] Gettotaljobsandposition()
        {
            Console.WriteLine("enter the number of elements and the position of your print");
            var n = Console.ReadLine();
            var data = n.Split(' ');
            return data;
        }

        public int Gettotaltest()
        {
            int input;
            Console.WriteLine("enter the number of test cases");
            input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
    }

    public class Makequeue
    {
        public Queue<int> Priorityqueue(string priorities)
        {
            Queue<int> myqueue = new Queue<int>();
            foreach (var pr in priorities.Split(' '))
            {
                myqueue.Enqueue(Convert.ToInt32(pr));
            }
            return myqueue;
        }
        public Queue<string> Referencequeue(int p,int r)
        {
            Queue<string> referencequeue = new Queue<string>();
            for (int t = 0; t < p; t++)
            {
                if (t != r)
                {
                    referencequeue.Enqueue("x");
                }
                else
                {
                    referencequeue.Enqueue("y");
                }
            }
            return referencequeue;
        }
    }

    public class Timerequired
    {
        public int Timetaken(Queue<int> myqueue, Queue<string> referqueue,int q)
        {
            int mypriority = myqueue.ElementAt(q), count = 0;
            do
            {
                int max = myqueue.Max();
                if (myqueue.Peek() == max)
                {
                    if (myqueue.Peek() == mypriority && referqueue.Peek() == "y")
                    {
                        count++;
                        break;
                    }
                    else
                    {
                        count++;
                        myqueue.Dequeue();
                        referqueue.Dequeue();
                    }

                }
                else
                {
                    int push = myqueue.Dequeue();
                    myqueue.Enqueue(push);
                    string pushreference = referqueue.Dequeue();
                    referqueue.Enqueue(pushreference);
                }

            } while (true);
            return count;
        }
    }
}
