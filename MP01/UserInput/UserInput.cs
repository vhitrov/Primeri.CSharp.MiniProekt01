﻿using System;

namespace UserInput
{

	public class UInput
	{
		About.Me about=new About.Me();

		public UInput ()
		{
		}

		public void sayHallo ()
		{
			Console.WriteLine ("Добре Дошли в "+about.shortName+"\n"+about.version+"\n");
		}

		public void getUserCommands ()
		{
			string _command = "";

			do
			{
				//Взимане на команда
				Console.Write("$ ");
				_command=Console.ReadLine();

				//Проверка за налични команди
				if(_command.ToLower().Contains("команда1")) Console.WriteLine("Стартирана е команда 1\n");
				if(_command.ToLower().Contains("команда2")) Console.WriteLine("Стартирана е команда 2\n");
				if(_command.ToLower().Contains("команда3")) Console.WriteLine("Стартирана е команда 3\n");

			}while (_command.ToLower() != "изход");
				

		}
		public void justTesting ()
		{
			Console.WriteLine ("Стартиране на UserInput.Uinput.justTesting");	
		}
	}
}

