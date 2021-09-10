using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
	class Journal
	{
		//fields
		private int password;
		private bool isUnlocked;
		private string entry;
		private string date;
		private bool isRunning = true;

		public bool IsRunning {get { return this.isRunning; }}

		//constructor
		public Journal(int password)
		{
			this.password = password;
			this.isUnlocked = false;
			this.isRunning = true;
		}

		//methods
		public void Menu()
		{
			Console.WriteLine("Menu:");
			Console.WriteLine("1) Unlock");
			Console.WriteLine("2) Create Entry");
			Console.WriteLine("3) Read Entry");
			Console.WriteLine("4) Lock");
			Console.WriteLine("5) Quit");
			Console.WriteLine("-------------------------");
		}
		public void Unlock()
		{
			Console.WriteLine("Enter the password:");
			int password = Convert.ToInt32(Console.ReadLine());
			if (password == this.password)
			{
				Console.WriteLine("Unlocked!");
				this.isUnlocked = true;
			}
			else
				Console.WriteLine("Incorrect password");
			Console.WriteLine();
		}
		public void CreateEntry()
		{
			if (this.isUnlocked)
			{
				Console.WriteLine("Enter your text:");
				this.entry = Console.ReadLine();
				this.date = DateTime.Now.ToString();
				Console.WriteLine("Saved!");
			}
			else
			{
				Console.WriteLine("The journal is locked!");
			}
			Console.WriteLine();
		}
		public void ReadEntry()
		{
			if (this.isUnlocked)
			{
				Console.WriteLine("The last entry (entered at {0}):", this.date);
				Console.WriteLine(this.entry);
			}
			else
			{
				Console.WriteLine("The journal is locked!");
			}
			Console.WriteLine();
		}
		public void Lock()
		{
			if (this.isUnlocked)
			{
				this.isUnlocked = false;
				Console.WriteLine("You locked the journal.");
			}
			else
				Console.WriteLine("The journal is already locked!");
			Console.WriteLine();
		}
		public void Quit()
		{
			Console.WriteLine("Goodbye!");
			this.isRunning = false;
		}

	}
}
