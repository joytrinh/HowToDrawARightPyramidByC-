using System.IO;
using System;

class Program
{
    static void Main()
    {
      int height = 5;
      for(int i = 0; i < height; i++)
		  {

			     for (int j = height - i; j > 1; j--)
           {
              Console.Write(" ");
            }
			     for (int k = 0; k <= i; k++)
			     {
				      Console.Write("#");
			     }
			Console.WriteLine("");
		  }
    }
}
