using System.IO;
using System;

class Program
{
    static void Main()
    {
        int height = 5;
        for(int i = 0; i < height; i++)
		{
			int j = height - i;
			while (j > 1)
			{
				Console.Write(" ");
				j--;
			}
			for(int k = 0; k <= i; k++)
			{
				Console.Write("#");
			}
			Console.WriteLine("");
		}
    }
}
