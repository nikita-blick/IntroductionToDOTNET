using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.CursorVisible = false;

			// Начальная позиция символа
			int x = 2, y = 2;

			char[] symbol = { '*' };
			int currentSymbolIndex = 0;

			bool running = true;

			Console.Clear();
			DrawSymbol(x, y, symbol[currentSymbolIndex]);

			while (running)
			{
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo keyInfo = Console.ReadKey(true);

					switch (keyInfo.Key)
					{
						case ConsoleKey.UpArrow:
							if (y > 0) y--;
							break;

						case ConsoleKey.DownArrow:
							if (y < 0) y++;
							break;

						case ConsoleKey.LeftArrow:
							if (x > 0) x--;
							break;

						case ConsoleKey.RightArrow:
							if (x < 0) x++;
							break;

						case ConsoleKey.Escape:
							running = false;
							break;
					}

					Console.Clear();
					DrawSymbol(x, y, symbol[currentSymbolIndex]);
					DisplayControls();
				}

				System.Threading.Thread.Sleep(50); // Небольшая задержка для плавности
			}

			Console.CursorVisible = true;
			Console.Clear();
			Console.WriteLine("Игра завершена. Нажмите любую клавишу...");
			Console.ReadKey();
		}

		static void DrawSymbol(int x, int y, char symbol)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(symbol);
		}

		static void DisplayControls()
		{
			Console.SetCursorPosition(0, 0);
			Console.Write("Управление: WASD или Стрелки | ESC - выход");
			
		}
	}
}
