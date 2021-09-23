using System;

namespace day8
{
    class pg6_Circularqueue
    {
        int[] a;
        int max, front, rear;
        pg6_Circularqueue()
        {
            front = 0;
            rear = -1;
            max = 5;
            a = new int[max];
        }
        void enqueue()
        {
            if (rear-front == max - 1)
                Console.WriteLine("Queue overflow");
            else
            {
                int ele = int.Parse(Console.ReadLine());
                rear++;
                a[rear%max] = ele;
            }
        }
        void dequeue()
        {
            if (front > rear)
            {
                Console.WriteLine("Queue underflow");
                front = 0;
                rear = -1;
            }
            else
            {
                Console.WriteLine("Deleting......." + a[front%max]);
                a[front % max] = 0;
                front++;
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
                for (int i = 0; i <max; i++)
                    Console.Write(a[i] + "\t");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int ch;
            pg6_Circularqueue ob = new pg6_Circularqueue();
            do
            {
                Console.WriteLine("1 ENQUEUE 2 DEQUEUE 3 DISPLAY 4 EXIT");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1: ob.enqueue(); break;
                    case 2: ob.dequeue(); break;
                    case 3: ob.display(); break;
                    case 4: break;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            } while (ch != 4);
        }
    }
}
