using System;

namespace UserInput
{

	public class UInput
	{
		About.Me about=new About.Me();
		Colors.ForCLI _c=new Colors.ForCLI();

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
				if(_command.ToLower().Contains("команда1")) 
				{
					_c.Defolt(); Console.Write("Стартирана е ");
					_c.Result(); Console.WriteLine("команда 1\n");
				}
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

