using System;

namespace Colors
{
	public class ForCLI
	{
		public ForCLI ()
		{
		}

		public void Defolt ()
		{
			Console.ForegroundColor = ConsoleColor.Gray;
		}

		public void Promt ()
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
		}

		public void Comand ()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
		}

		public void Result ()
		{
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}

