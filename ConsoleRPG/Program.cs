using ConsoleRPG.Characters;
using ConsoleRPG.Utility;


var enemy = new Enemy();
var player = new Character();
Text.GameStartMenu();
Text.ParseInputToInt(Console.ReadLine());
Text.CharacterInfo(player);
Character.Attack(player);
Character.Attack(enemy);
Text.CharacterInfo(enemy);
enemy.Name = "CHANGED NAME";
Text.CharacterInfo(enemy);
Text.CharacterInfo(player);

Character.Attack(player);
Character.Attack(enemy);

Text.CharacterInfo(enemy);
Text.CharacterInfo(player);