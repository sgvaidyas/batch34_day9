using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    class Pg5_QueueImplement
    {
        int[] a;
        int max, front, rear;
        Pg5_QueueImplement()
        {
            front = 0;
            rear = -1;
            max = 5;
            a = new int[max];
        }
        void enqueue()
        {
            if(rear==max-1)
                Console.WriteLine("Queue overflow");
            else
            {
                int ele = int.Parse(Console.ReadLine());
                a[++rear] = ele;
            }
        }
        void dequeue()
        {
            if(front>rear)
            {
                Console.WriteLine("Queue underflow");
                front = 0;
                rear = -1;
            }
            else
            {
                Console.WriteLine("Deleting......."+a[front++]);
            }
        }
        void display()
        {
            if (front > rear)
            {
                Console.WriteLine("Queue empty");
            }
            else
            {
                Console.WriteLine("Queue elements are");
                for(int i=front;i<=rear;i++)
                    Console.Write(a[i]+"\t");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int ch;
            Pg5_QueueImplement ob = new Pg5_QueueImplement();
            do
            {
                Console.WriteLine("1 ENQUEUE 2 DEQUEUE 3 DISPLAY 4 EXIT");
                ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1: ob.enqueue();break;
                    case 2: ob.dequeue(); break;
                    case 3: ob.display(); break;
                    case 4:break;
                    default: Console.WriteLine("Invalid choice");break;
                }
            } while (ch != 4);
        }
    }
}
