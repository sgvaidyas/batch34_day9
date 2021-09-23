using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
	class Recursion1
	{
		//ascending 1....9
		static void print(int n)
		{
			if (n == 0)
				return;
			print(n - 1);
			Console.WriteLine(n);
		}
		//descending 9...1
		static void printdesc(int n)
		{
			if (n == 0)
				return;
			Console.WriteLine(n);
			printdesc(n - 1);			
		}
		static void Main(string[] args)
		{
			print(9);
			Console.WriteLine("__________________");
			printdesc(4);
		}
	}
}
