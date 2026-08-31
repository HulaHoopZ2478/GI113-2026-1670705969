/*
 * Student ID : 1670705969
 * Name       : Korawit Nakthong
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name;
            char rank;
            int level;
            int maxHp;
            int currentHp;
            float attackPower;
            double critMultiplier;
            bool isBoss;
            int hpPercent;

            Name = "Kirin";
            rank = 'S';
            level = 7;
            maxHp = 240;
            currentHp = 175;
            attackPower = 42.5f;
            critMultiplier = 1.75;
            isBoss = true;
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine("===== Boss STATUS: INITAIL =====");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"IS BOSS: {isBoss}");
            Console.WriteLine();
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine("Kirin takes 60 damage!");
            currentHp = currentHp - 60;

            Console.WriteLine("===== Boss STATUS: AFTER DAMAGE =====");
            int hpPercentTdmg = currentHp * 100 / maxHp;
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: {hpPercentTdmg}%");
            Console.WriteLine();

			Name = "Fatalis";
			rank = 'S';
			level = 10;
			maxHp = 500;
			currentHp = 267;
			attackPower = 83.5f;
			critMultiplier = 2.00;
			isBoss = true;
			hpPercent = currentHp * 100 / maxHp;
			Console.WriteLine("===== Boss STATUS: INITAIL =====");
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine($"Rank: {rank}");
			Console.WriteLine($"Level: {level}");
			Console.WriteLine($"HP: {currentHp} / {maxHp}");
			Console.WriteLine($"Attack Power: {attackPower}");
			Console.WriteLine($"Crit Multiplier: {critMultiplier}");
			Console.WriteLine($"IS BOSS: {isBoss}");
			Console.WriteLine();
			Console.WriteLine($"HP Percent: {hpPercent}%");
			Console.WriteLine();

			Name = "Lycan";
			rank = 'D';
			level = 2;
			maxHp = 100;
			currentHp = 78;
			attackPower = 24.5f;
			critMultiplier = 1.00;
			isBoss = false;
			hpPercent = currentHp * 100 / maxHp;
			Console.WriteLine("=== Player ===");
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine($"Rank: {rank}");
			Console.WriteLine($"Level: {level}");
			Console.WriteLine($"HP: {currentHp} / {maxHp}");
			Console.WriteLine($"Attack Power: {attackPower}");
			Console.WriteLine($"Crit Multiplier: {critMultiplier}");
			Console.WriteLine($"IS BOSS: {isBoss}");
			Console.WriteLine();
			Console.WriteLine($"HP Percent: {hpPercent}%");
			Console.WriteLine();

			Name = "Norma";
			rank = 'C';
			level = 4;
			maxHp = 120;
			currentHp = 100;
			attackPower = 32.5f;
			critMultiplier = 1.00;
			isBoss = false;
			hpPercent = currentHp * 100 / maxHp;
			Console.WriteLine("=== Player ===");
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine($"Rank: {rank}");
			Console.WriteLine($"Level: {level}");
			Console.WriteLine($"HP: {currentHp} / {maxHp}");
			Console.WriteLine($"Attack Power: {attackPower}");
			Console.WriteLine($"Crit Multiplier: {critMultiplier}");
			Console.WriteLine($"IS BOSS: {isBoss}");
			Console.WriteLine();
			Console.WriteLine($"HP Percent: {hpPercent}%");
			Console.WriteLine();

			Name = "Nergigante";
			rank = 'S';
			level = 9;
			maxHp = 360;
			currentHp = 270;
			attackPower = 61.5f;
			critMultiplier = 1.75;
			isBoss = false;
			hpPercent = currentHp * 100 / maxHp;
			Console.WriteLine($"\n===== Boss STATUS: INITAIL =====\nName: {Name}\nRank: {rank}\nLevel: {level}\nHp: {currentHp} / {maxHp}\nAttack Power: {attackPower}\nCrit Multiplier: {critMultiplier}\nIS BOSS: {isBoss}\n\nHP Percent {hpPercent}%\n");
		}

    }
}
