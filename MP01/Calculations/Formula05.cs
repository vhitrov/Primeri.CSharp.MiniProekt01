using System;

namespace Calculations
{
	public class Formula05
	{
		Colors.ForCLI _cl = new Colors.ForCLI();

		public Formula05 ()
		{
		}

		public void calc (string _input)
		{
			try
			{
				string[] param = _input.Split (' ');

				if(param.Length>1 && _input.ToLower().Contains("-п"))
				{
					help();
				}

				if( param.Length==5 )
				{
					double result=0;

					if( runCalculate(param, out result) )
					{
						_cl.Defolt ();  Console.Write("Обема на каналният изкоп е ");
						_cl.Result ();  Console.Write(result.ToString("N2"));
						_cl.Defolt ();  Console.WriteLine(" m3\n");
					}else
					{
						_cl.Defolt ();  Console.WriteLine("Има грешно въведени параметри. С параметъра '-п' можете\nда видите синтаксиса на командата.\n");
					}


				}
			}catch{
			}
		}

		private bool runCalculate (string [] _param, out double _result)
		{
			try
			{
				double a=0; Double.TryParse(_param[1], out a);
				double b=0; Double.TryParse(_param[2], out b);
				double h=0; Double.TryParse(_param[3], out h);
				double L=0; Double.TryParse(_param[4], out L);

				_result=(a+b)/2*h*L;

				return true;
			}catch{
			}

			_result = 0;
			return false;
		}

		private void help ()
		{
			_cl.Result ();  Console.Write ("[кизкоп]");
			_cl.Defolt ();  Console.WriteLine (" - канален изкоп");

			_cl.Comand ();  Console.Write ("параметри: ");
			_cl.Defolt ();  Console.WriteLine ("a, b, h и L\n");

			_cl.Comand ();  Console.Write ("a и b");
			_cl.Defolt ();  Console.WriteLine (" - горна и долна ширина на профила");

			_cl.Comand (); Console.Write ("h");
			_cl.Defolt (); Console.WriteLine (" - височина");

			_cl.Comand (); Console.Write ("L");
			_cl.Defolt (); Console.WriteLine (" - дължина\n");
		}


	}
}

