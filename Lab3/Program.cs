using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
			Console.WriteLine("Hello and welcome to IS IT ODD OR IS IT EVEN!");
			Console.WriteLine();

			Console.Write("User please state your name: ");
			string Name = (Console.ReadLine());
			Console.WriteLine($"Thank you, {Name}.");
			Console.WriteLine();

			start:
			Console.Write($"{Name} could you please enter a number from 1-100: ");

			string Input = (Console.ReadLine());
			Console.WriteLine();

			int Number;
			bool Success = int.TryParse(Input, out Number);

			if (Success)
			{
				if (Number > -1 && Number >= 1 && Number <= 100 && Number != 0)
				{
					if (Number % 2 != 0)
					{
						Console.WriteLine($"{Name} the number {Number} is odd.");
						Console.WriteLine($"{Name} would you like to check another number? Y/N");
						string Continue = Console.ReadLine();
						string Yes = "Y";
						string No = "N";

						if (Continue.ToUpper() == Yes || Continue.ToLower() == Yes)
						{
							goto start;
						}
						else if (Continue.ToUpper() == No || Continue.ToLower() == No)
						{
							Console.WriteLine();
							Console.WriteLine($"Thank you {Name}, have a nice day. ");
							return;
						}
					}
					else if (Number % 2 != 0 && Number > 60)
					{
						Console.WriteLine($"{Name} the number {Number} is odd.");
						Console.WriteLine($"{Name} would you like to check another number? Y/N");
						string Continue = Console.ReadLine();
						string Yes = "Y";
						string No = "N";

						if (Continue.ToUpper() == Yes || Continue.ToLower() == Yes)
						{
							goto start;
						}
						else if (Continue.ToUpper() == No || Continue.ToLower() == No)
						{
							Console.WriteLine();
							Console.WriteLine($"Thank you {Name}, have a nice day. ");
							return;
						}
					}
					else if (Number % 2 == 0 && Number < 25)
					{
						Console.WriteLine($"{Name} the number {Number} is even and less than 25.");
						Console.WriteLine($"{Name} would you like to check another number? Y/N");
						string Continue = Console.ReadLine();
						string Yes = "Y";
						string No = "N";

						if (Continue.ToUpper() == Yes || Continue.ToLower() == Yes)
						{
							goto start;
						}
						else if (Continue.ToUpper() == No || Continue.ToLower() == No)
						{
							Console.WriteLine();
							Console.WriteLine($"Thank you {Name}, have a nice day. ");
							return;
						}
					}
					else if (Number % 2 == 0 && Number >= 26 && Number <= 60)
					{
						Console.WriteLine($"{Name} the number {Number} is even.");
						Console.WriteLine($"{Name} would you like to check another number? Y/N");
						string Continue = Console.ReadLine();
						string Yes = "Y";
						string No = "N";

						if (Continue.ToUpper() == Yes || Continue.ToLower() == Yes)
						{
							goto start;
						}
						else if (Continue.ToUpper() == No || Continue.ToLower() == No)
						{
							Console.WriteLine();
							Console.WriteLine($"Thank you {Name}, have a nice day. ");
							return;
						}
					}
					else if (Number % 2 == 0 && Number > 60)
					{
						Console.WriteLine($"{Name} the number {Number} is even.");
						Console.WriteLine($"{Name} would you like to check another number? Y/N");
						string Continue = Console.ReadLine();
						string Yes = "Y";
						string No = "N";

						if (Continue.ToUpper() == Yes || Continue.ToLower() == Yes)
						{
							goto start;
						}
						else if (Continue.ToUpper() == No || Continue.ToLower() == No)
						{
							Console.WriteLine();
							Console.WriteLine($"Thank you {Name}, have a nice day. ");
							return;
						}
					}
				}
				else
				{
					Console.WriteLine();
					Console.WriteLine($"I'm sorry {Name} that number is invalid please try again.");
					Console.WriteLine();
					goto start;
				}
			}
			else
			{
				Console.WriteLine();
				Console.WriteLine($"I'm sorry {Name} that is not a valid entry please try again.");
				Console.WriteLine();
				goto start;
			}
		}
	}
}
