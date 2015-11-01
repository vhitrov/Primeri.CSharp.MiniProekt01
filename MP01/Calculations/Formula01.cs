using System;

namespace Calculations
{
	/// <summary>
	/// Клас за формула за обикновена строителна яма (Формула01).</summary>
	public class Formula01
	{
		//Библиотеки
		private Colors.ForCLI _c=new Colors.ForCLI();

		/// <summary>
		/// Конструктор на Формула 01.</summary>
		public Formula01 () 
		{
		}

		//Присвояване
		public void calc (string _userInput)
		{
			try{
				string [] param=_userInput.Split(' ');

				if(param.Length > 1 && _userInput.Contains ("-п"))
				{
					//Помощ за командата
					help();
				}

				if(param.Length >1 && !_userInput.Contains("-п"))
				{
					//Изчисления
					double _result=0;

					if (runCalculations(param, out _result))
					{
						_c.Defolt(); Console.Write("Обема на строителната яма е: ");
						_c.Result(); Console.Write(_result.ToString("N2"));
						_c.Defolt(); Console.WriteLine(" м3\n");
					}else{
						_c.Defolt(); Console.WriteLine("Има грешно въведени параметри. Можете да проверите синтаксиса с параметъра '-п'");
					}
				}
			} catch {
			}
		}

		/// <summary>
		/// Вътрешен метод за пресмятане на Формула 01, след парсване на командата от потребителя.</summary>
		private bool runCalculations(string[] _param, out double _result)
		{
			try {
				double _a1=0, _b1=0, _a2=0, _b2=0, _h=0;

				//_param[0] == <име на команда>
				Double.TryParse (_param[1], out _a1);
				Double.TryParse (_param[2], out _b1);
				Double.TryParse (_param[3], out _a2);
				Double.TryParse (_param[4], out _b2);
				Double.TryParse (_param[5], out _h);

				double F1=_a1*_b1, F2=_a2*_b2;
				_result=_h*(F1+F2)/2;

				return true;
			} catch {
			}

			_result = 0;
			return false;
		}


		/// <summary>
		///Вътрешен метод показващ синтаксиса на командата в командният ред .</summary>
		private void help()
		{
			_c.Result (); Console.Write ("[яма]");
			_c.Defolt (); Console.WriteLine (" - команда за пресмятане на строителна яма");

			_c.Result (); Console.Write ("параметри: ");
			_c.Defolt (); Console.WriteLine ("a1 b1 a2 b2 h\n");

			_c.Result (); Console.Write ("a1 и b1");
			_c.Defolt (); Console.WriteLine (" - ширина и дължина на горната страна на изкопа");

			_c.Result (); Console.Write ("a2 и b2");
			_c.Defolt (); Console.WriteLine (" - ширина и дължина на долната страна на изкопа");

			_c.Result (); Console.Write ("h");
			_c.Defolt (); Console.WriteLine (" - височина на изкопа\n");

		}
	}
}