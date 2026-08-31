/*
 * Student ID : 1670705969
 * Name       : Korawit Nakthong
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int Maxlevel = 10;

			var bossName = "Kirin";
			var rank = 'S';
			int level = 7;
			int maxHp = 240;
			int currentHp = 115;
			float attackPower = 42.5f;
			double critMultiplier = 1.75;
			bool isBoss = true;

			Console.WriteLine($"===== KIRIN SAVE CONVERTER=====\nName: {bossName}\nRank: {rank}\nLevel: {level}/{Maxlevel}\nHP: {currentHp} / {maxHp}\nAttack Power: {attackPower}\nCrit Multiplier: {critMultiplier}\nIs Boss: {isBoss}");

			Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
			double currentHpDouble = currentHp;
			Console.WriteLine($"HP (double): {currentHpDouble}");

			Console.WriteLine("\n----- Exct HP Percent (no integer truncation) -----");
			double hpPercent = currentHpDouble * 100 / maxHp;
			Console.WriteLine($"Hp Percent (exact) {hpPercent}%");

			Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display int -----");
			int attackINT = (int)attackPower;
			Console.WriteLine($"Attack Power (int cast): {attackINT}");

			Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
			int critCast = (int)critMultiplier;
			Console.WriteLine($"Crit Multiplier (int cast): {critCast}");

			int critConvert = Convert.ToInt32(critMultiplier);
			Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
		}
	}
}
