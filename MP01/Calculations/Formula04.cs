using System;

namespace Calculations
{
	public class Formula04
	{
		Colors.ForCLI _cl = new Colors.ForCLI();

		public Formula04 ()
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

				if( param.Length==4 )
				{
					double result=0;

					if( runCalculate(param, out result) )
					{
						_cl.Defolt ();  Console.Write("Обема на страничният ъгъл е ");
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
				double h=0; Double.TryParse(_param[2], out h);
				double L=0; Double.TryParse(_param[3], out L);

				_result=(a*h/2)*L;

				return true;
			}catch{
			}

			_result = 0;
			return false;
		}


		private void help ()
		{
			_cl.Result ();  Console.Write ("[съгъл]");
			_cl.Defolt ();  Console.WriteLine (" - страничен ъгъл");

			_cl.Comand ();  Console.Write ("параметри: ");
			_cl.Defolt ();  Console.WriteLine ("a, h и L\n");

			_cl.Comand ();  Console.Write ("h и L");
			_cl.Defolt ();  Console.WriteLine (" - височина и дължина");

			_cl.Comand (); Console.Write ("L");
			_cl.Defolt (); Console.WriteLine (" - ширина на профила\n");
		}

	}
}

