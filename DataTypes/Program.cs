using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		const string delimiter = "\n---------------------------\n";
		static void Main(string[] args)
		{
			Console.WriteLine($"bool занимает {sizeof(bool)} Байт памяти, класс обвертка Boolean;");
			Console.WriteLine(bool.FalseString);
			Console.WriteLine(bool.TrueString);
			Console.WriteLine(typeof(bool));
			Console.WriteLine(delimiter);
			bool rain = true;
			Console.WriteLine($"Дождь идет? - {rain}");


			////////////////////////////////////////////////////////////////////////////////////////
			Console.WriteLine(delimiter);
			Console.WriteLine
				(
				$@"Тип данных char занимает {sizeof(char)} Байт памяти, и принимает значение в диапазоне
от {(int)char.MinValue} до {(int)char.MaxValue}. Класс-обвертка - {typeof(char)}" 
				);
			//@"RAW-строка игнорирует все специальные символы и Esc-последовательности. то есть воспринимается как есть.

			Console.WriteLine(delimiter);
			Console.WriteLine(@"RAW-строка \t\n");
			Console.WriteLine(delimiter);
			////////////////////////////////////////////////////////////////////////////////////////

			Console.WriteLine(
$@"byte занимает {sizeof(byte)} Байт памяти, и принимает значения в диапазоне от {byte.MinValue}
до {byte.MaxValue}. Класс-обвертка - {typeof(byte)}
"
				);

			Console.WriteLine(delimiter);

			Console.WriteLine(
$@"byte занимает {sizeof(sbyte)} Байт памяти, и принимает значения в диапазоне от {sbyte.MinValue}
до {sbyte.MaxValue}. Класс-обвертка - {typeof(sbyte)}
"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine($@"byte занимает {sizeof(decimal)} Байт памяти");
			double a = 1;
			a /= 3;
			Console.WriteLine(a);
			a *= 3;
			Console.WriteLine(a);

        
		
		}
	}
}
