
/*
* Student ID : 1670705969
* Name       : Korawit Nakthong
* Section    : 129A
* No.        : 7
* Course     : GI113 Computer Programming (GI)
*/
using System;

namespace Assignment01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const string GameTitle = "Elden ring";

			var characterClass = "Knight";
			var rankCode = 'A';

			int maxHealth = 1500;
			float attackPower = 250.5f;
			double manaRegen = 45.5;   
			bool isReady = true;

			Console.WriteLine($"====================================");
			Console.WriteLine($"       {GameTitle} - Stat Card      ");
			Console.WriteLine($"====================================");
			Console.WriteLine($" Class      : {characterClass}");
			Console.WriteLine($" Rank       : {rankCode}");
			Console.WriteLine($" Max Health : {maxHealth}");
			Console.WriteLine($" Attack Pwr : {attackPower}");
			Console.WriteLine($" Mana Regen : {manaRegen}");
			Console.WriteLine($" Ready?     : {isReady}");
			Console.WriteLine($"====================================");
			Console.WriteLine();

			double healthAsDouble = maxHealth;
			Console.WriteLine($"[Implicit] Health (int to double) : {healthAsDouble}");

			int manaCast = (int)manaRegen;
			int manaConvert = Convert.ToInt32(manaRegen);

			Console.WriteLine($"[Explicit] Mana Regen (Cast)      : {manaCast}");
			Console.WriteLine($"[Convert]  Mana Regen (Convert)   : {manaConvert}");
		}
	}
}