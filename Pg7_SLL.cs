using System;

namespace day8
{
	class Node
	{
		public int data;
		public Node address;
		public static int count = 0;
		public Node(int ele)
		{
			data = ele;
			address = null;
			count++;
		}
	}
	class Pg7_SLL
	{
		Node head;
		public Pg7_SLL()
		{
			head = null;
		}

		public void insertBegin(int ele)
		{
			Node newnode = new Node(ele);
			if (head == null)
				head = newnode;
			else
			{
				newnode.address = head;
				head = newnode;
			}
		}
		public void insertend(int ele)
		{
			Node newnode = new Node(ele);
			if (head == null)
				head = newnode;
			else
			{
				Node temp = head;
				while (temp.address != null)
					temp = temp.address;
				temp.address = newnode;
			}
		}

		public void insertpos(int ele,int pos)
		{
			if (pos == 1)
				insertBegin(ele);
			else if (pos == Node.count + 1)
				insertend(ele);
			else
			{
				Node newnode = new Node(ele);
				Node pp, cp;
				pp = cp = head;
				for(int i=1; i<pos; i++)
				{
					pp = cp;
					cp = cp.address;
				}
				pp.address = newnode;
				newnode.address = cp;
			}
		}
		public void deletebeg()
		{
			if(head==null)
				Console.WriteLine("List empty hence cannot delete");
			else
			{
				Console.WriteLine("Deleting .... "+ head.data);
				head = head.address;
				Node.count--;
			}
		}
		public void deleteend()
		{
			if (head == null)
				Console.WriteLine("List empty hence cannot delete");
			else
			{
				Node pp, cp;
				pp = cp = head;

				while(cp.address!=null)
				{
					pp = cp;
					cp = cp.address;
				}
				Console.WriteLine("deleting ...."+cp.data);
				pp.address = null;
				if (pp == cp)
					head = null;
				Node.count--;
			}
		}
		public void deletepos(int pos)
		{
			if (pos == 1)
				deletebeg();
			else if (pos == Node.count)
				deleteend();
			else
			{
				Node pp,cp;
				pp = cp = head;
				for(int i=1;i<pos;i++)
				{
					pp = cp;
					cp = cp.address;
				}
				Console.WriteLine("DELETING ...."+cp.data);
				pp.address = cp.address;
				Node.count--;
			}
		}

		public int search(int key)
		{
			int found = 0;
			Node temp = head;
			while(temp!=null)
			{
				if (key == temp.data)
				{
					found = 1;
					return found;
				}
				temp = temp.address;
			}
			return found;
		}






		public void display()
		{
			if(head==null)
				Console.WriteLine("no elements in list");
			else
			{
				Node temp = head;
				Console.WriteLine("the elements are ");
				while(temp!=null)
				{
					Console.WriteLine(temp.data);
					temp = temp.address;
				}
			}
		}
	}
}
