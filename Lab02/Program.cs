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
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            int hpPercent = currentHp * 100 / maxHp;

            Console.WriteLine("===== Boss STATUS: INITAIL =====");
            Console.WriteLine($"Name: {bossName}");
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
