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



        }

    }
}
