using System;

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
				if(_command.ToLower().Contains("яма"))     _calc.F01.calc(_command);

				if(_command.ToLower().Contains("въгъл"))   _calc.F02.calc(_command);

				if(_command.ToLower().Contains("иъгъл"))   _calc.F03.calc(_command);

				if(_command.ToLower().Contains("съгъл"))   _calc.F04.calc(_command);

				if(_command.ToLower().Contains("кизкоп"))  _calc.F05.calc(_command);

				if(_command.ToLower().Contains("помощ") || 
					_command.ToLower() == "п")            _calc.comands();

				if(_command.ToLower() == "изчисти" ||
					_command.ToLower() == "и")
				{
					Console.Clear();
					_c.Defolt();
					Console.WriteLine ("Добре Дошли в "+about.shortName+"\n"+about.version+"\n");
				}

			}while (_command.ToLower() != "изход");
				

		}
		public void justTesting ()
		{
			Console.WriteLine ("Стартиране на UserInput.Uinput.justTesting");	
		}
	}
}

