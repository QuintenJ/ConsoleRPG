namespace ConsoleRPG.Characters
{
    public class Character
    {
        public string Name { get; set; } 
        public int Level { get; set; } = 1;
        public int HitPoints { get; set; } = 100;
        public int Coins { get; set; } = 1000;

        public Character(string name = "NO NAME CHOSEN")
        {
            Name = name;
        }

        public static void Attack(Character character)
        {
            if (character.HitPoints >= 100)
            {
                character.HitPoints -= 20;
            }
            else
            {
                character.HitPoints -= 10;
            }
            Console.WriteLine($"Attacked! HitPoints Remaining {character.HitPoints}");
        }
    }
}
