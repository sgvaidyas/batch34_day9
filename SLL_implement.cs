using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
	class SLL_implement
	{
		static void Main(string[] args)
		{
			int ch,ele,pos;
			Pg7_SLL ob = new Pg7_SLL();
			do
			{
				Console.WriteLine("1 Insert in beginning");
				Console.WriteLine("2 Insert at the end");
				Console.WriteLine("3 Insert at the pos");
				Console.WriteLine("4 Delete at the beginning");
				Console.WriteLine("5 Delete at the end");
				Console.WriteLine("6 Delete at the pos");
				Console.WriteLine("7 Display");
				Console.WriteLine("8 Search");
				Console.WriteLine("9 Exit");
				ch = int.Parse(Console.ReadLine());
				switch(ch)
				{
					case 1:
						    Console.WriteLine("Insert element = ");
							ele= int.Parse(Console.ReadLine());
							ob.insertBegin(ele);
							break;
					case 2:
						Console.WriteLine("Insert element = ");
						ele = int.Parse(Console.ReadLine());
						ob.insertend(ele);
						break;
					case 3:
						do
						{
							Console.WriteLine("enter pos between 1 to "+ (Node.count+1));
							pos = int.Parse(Console.ReadLine());
						} while (pos<1 || pos>Node.count+1);
						Console.WriteLine("Insert element = ");
						ele = int.Parse(Console.ReadLine());
						ob.insertpos(ele,pos);
						break;
					case 4:ob.deletebeg();break;
					case 5:ob.deleteend();break;
					case 6:
						do
						{
							Console.WriteLine("enter pos between 1 to " + (Node.count));
							pos = int.Parse(Console.ReadLine());
						} while (pos < 1 || pos > Node.count );
						ob.deletepos(pos);
						break;
					case 7:ob.display();break;
					case 8:
						Console.WriteLine("Insert element = ");
						ele = int.Parse(Console.ReadLine()); 
						if(ob.search(ele)==1)
							Console.WriteLine("Search key is found");
						else
							Console.WriteLine("Search key is not found");
						break;
					case 9:break;
				}
			} while (ch != 9);
		}
	}
}
