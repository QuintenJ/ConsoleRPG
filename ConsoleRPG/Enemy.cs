using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Enemy : Character
    {
        public Enemy(string name = "Monster") : base(name)
        {
        }

        public void Heal(Character character)
        {
            character.Health += 100;
            Console.WriteLine($"Enemy Has Been Healed! {Health}");
        }
    }
}
