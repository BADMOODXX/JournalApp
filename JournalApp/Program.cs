using System;
using System.IO;
namespace Learning
{
	class Program
	{
		static void Main(string[] args)
		{
			//Journal
			Journal j = new Journal(1234);
			while (j.IsRunning)
			{
				j.Menu();
				char token = Console.ReadLine()[0];
				switch (token)
				{
					case '1':
						j.Unlock();
						break;
					case '2':
						j.CreateEntry();
						break;
					case '3':
						j.ReadEntry();
						break;
					case '4':
						j.Lock();
						break;
					case '5':
						j.Quit();
						break;
					default:
						Console.WriteLine("Invalid token");
						break;
				}

			}
			
		}
	}
}
