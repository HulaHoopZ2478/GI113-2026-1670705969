/*
* Student ID : 1670705969
* Name       : Korawit Nakthong
* Section    : 129A
* No.        : 7
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" ===> BATTLE MAGE <=== ");
			Console.WriteLine("Hero vs. Monsters -- Fight Calculator ");

			// User input of Hero stats
			Console.Write("Hero Health: ");
			bool isHeroHp = int.TryParse(Console.ReadLine(), out int heroHp);
			Console.Write("Hero Attack: ");
			bool isHeroAtk = int.TryParse(Console.ReadLine(), out int heroAtk);
			Console.Write("Hero Defence: ");
			bool isHeroDef = int.TryParse(Console.ReadLine(), out int heroDef);
			Console.WriteLine();

			// User input of Monster stats
			Console.Write("Monster Health: ");
			bool isMonsHp = int.TryParse(Console.ReadLine(), out int MonsHp);
			Console.Write("Monster Attack: ");
			bool isMonsAtk = int.TryParse(Console.ReadLine(), out int MonsAtk);
			Console.Write("Monster Defence: ");
			bool isMonsDef = int.TryParse(Console.ReadLine(), out int MonsDef);
			Console.WriteLine();

			// Check if player input is Valid
			bool allHeroValid = isHeroHp && isHeroAtk && isHeroDef;
			bool allMonsValid = isMonsHp && isMonsAtk && isMonsDef;
			Console.WriteLine($"Stats Validation: HERO: {allHeroValid}, MONSTER: {allMonsValid}");
			Console.WriteLine();
			Console.WriteLine($"[HERO]      HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
			Console.WriteLine($"[MONSTER]   HP: {MonsHp} ATK: {MonsAtk} DEF: {MonsDef}");
			Console.WriteLine();

			// Before fighting: Hero drinks a potion (Compound Assignment: +=)
			int potionHeal = 8;
			// 1. heroHp = heroHp + potionHeal;
			
			/*2.*/heroHp += potionHeal; // แนะนำแบบนี้ คำนวณเหมือนกัน 1 = 1+2
			Console.WriteLine($"Hero drinks a potion, Healing {potionHeal}. health is now {heroHp}.");

			// คำนวณ damage normal attack (Arithmetic + Math)
			int normalDamage = Math.Max(0, heroAtk - MonsDef);
			Console.WriteLine($"Normal Attack deal: {normalDamage} DMG");

			// คำนวณ power attack (Predence ลำดับการคำนวณ คูณ ก่อนที่จะ ลบ)
			int powerDamage = Math.Max(0, heroAtk * 2 - MonsDef);  // เรียงลำดับ * มาก่อน - ไม่จำเป็นต้องมี ( )
			Console.WriteLine($"Power Attack deal: {powerDamage} DMG");

			// คำนวณ Monster Attack
			int counterDamage = Math.Max(0, MonsAtk - heroDef);
			Console.WriteLine($"Monster Counter Attack deal: {counterDamage} DMG");

			// คำนวณ Crit Chance
			Random rng = new Random();
			int roll = rng.Next(1, 101); // สุ่ม Crit 1-100
			bool isCrit = roll <= 10; // 10%
			int critDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // โอกาส 10% ติดคริ เลขได้ 1 ไม่ติดได้ 0
			Console.WriteLine($"\nCritical hit roll: {roll} (critical: {isCrit})");
			Console.WriteLine($"Normal Attack would deal Critical: {critDamage} DMG");
		}
	}
}
