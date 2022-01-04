using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Character
    {
        public string Name { get; set; } = "Player";
        public int Coins { get; set; } = 0;
        public int Health { get; set; } = 100;
        public double Level { get; set; } = 1.0;

        public Character(string playerName = "Player")
        {
            Name = playerName;
        }
        public void DisplayCharacterInfo()
        {
            Console.WriteLine($"Character Created \n Character Name: {Name}, Coins: {Coins} Health: {Health} Level: {Level}");
        }

        public void Attack(Character character)
        {
            Random random = new Random();
            character.Health -= random.Next(1, 15);
        }
        public void Heal(Character character)
        {
            character.Health += 50;
            Console.WriteLine($"You've been Healed! {Health}");
        }
    }
}
