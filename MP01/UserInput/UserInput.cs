﻿using System;

namespace UserInput
{

	public class UInput
	{
		About.Me about=new About.Me();
		Colors.ForCLI _c=new Colors.ForCLI();
		Calculations.MainLibrary _calc = new Calculations.MainLibrary();


		public UInput ()
		{
		}

		public void sayHallo ()
		{
			_c.Defolt ();
			Console.WriteLine ("Добре Дошли в "+about.shortName+"\n"+about.version+"\n");
		}

		public void getUserCommands ()
		{
			string _command = "";

			do
			{
				//Взимане на команда
				_c.Promt(); Console.Write("$ ");
				_c.Comand(); _command=Console.ReadLine();

				//Проверка за налични команди
				if(_command.ToLower().Contains("яма"))    _calc.F01.calc(_command);
				if(_command.ToLower().Contains("въгъл"))  _calc.F02.calc(_command);

				if(_command.ToLower().Contains("команда3")) Console.WriteLine("Стартирана е команда 3\n");

			}while (_command.ToLower() != "изход");
				

		}
		public void justTesting ()
		{
			Console.WriteLine ("Стартиране на UserInput.Uinput.justTesting");	
		}
	}
}

