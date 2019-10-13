using System;

namespace lesson7
{
	class Program
	{
		static void Main(string[] args)
		{
			//multiplication tabel//

			/*int userNumber;
			Console.WriteLine("Enter a number: ");
			userNumber = Int32.Parse(Console.ReadLine());
						
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine($"{userNumber} X {i}= {userNumber * i}");
			}
			Console.ReadLine();*/

			/*string name;
			Console.WriteLine("Enter You name: ");
			name= Console.ReadLine();

			int counter = 0;
			//foreach kasutatakse kui me otsime midagi//
			foreach (char letter in name)
			{
				counter++;
			}
			Console.WriteLine($"Your name is {counter} letters long.");
			Console.ReadLine();*/

			/*string name;
			Console.WriteLine("Enter You name: ");
			name = Console.ReadLine();

			bool letterFound = false;

			foreach (char letter in name)
			{
				if (letter == 'a')
				{
					letterFound = true;
				}
								
			}
			if(letterFound)
			{
            Console.WriteLine("Found an A");
			}
			else
			{
				Console.WriteLine("There is no A in your name");

			}
			/*
			string result = letterFound ? "Includes an A : doesnt include an a";
			Console.WriteLine(result);

			Console.ReadLine();*/


			/*int aTotal = 0;
			string name;
			Console.WriteLine("Enter You name: ");
			name = Console.ReadLine();

			int length = name.Length;
			

			for (int i = 0; i < name.Length; i++)
			{
				if (name[i] == 'a')
				{
					aTotal++;
				}
			}

			Console.WriteLine($"There are {aTotal} \"A\" letters in your name.");

	 		Console.ReadLine();*/

			//write a programm in C# to separate the individual characters from a string- tühikud tähtede vahele


			/*string name;
			Console.WriteLine("Enter You name: ");
			name = Console.ReadLine();
			
			foreach (char letter in name)
			{
				Console.Write($"{letter} ");
			}
			Console.ReadLine();*/

			/*string name;
			Console.WriteLine("Enter You name: ");
			name = Console.ReadLine();

			for (int i = 0; i < name.Length; i++)
			{
				Console.Write($"{name[i]}* ");
			}
			Console.ReadLine();*/

			/*string name;
			Console.WriteLine("Enter You name: ");
			name = Console.ReadLine();

			for (int i = 0; i < name.Length; i++)
			{
				if(i==name.Length-1)
				{
					Console.Write($"{name[i]}");
					break;
				}

				Console.Write($"{name[i]}* ");
			}
			Console.ReadLine();*/

			//teha seda whileiga.mis tingimus peaks olema, et while loop väljuks//võib kasutada seda i-d.,//

			/*int i = 1;

			while (i<=10)
			{
				Console.WriteLine(i);
				i++;
			}
			Console.ReadLine();*/

			string hello = "hello";

			int i = 0;

			while( i < hello.Length)
			{
				Console.WriteLine($"{hello[i]} ");
			}

			Console.ReadLine();
		}
	}
}
