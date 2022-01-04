using ConsoleRPG;

Story.ScenesSetup();
Story.StartScene();
var enemy = new Enemy();
Console.Write("Enter Character Name: ");
string playerName = Console.ReadLine();

Console.WriteLine("Thank you......\nBuilding Character......");
var player = new Character(playerName);
enemy.DisplayCharacterInfo();
player.DisplayCharacterInfo();
player.Heal(player);
enemy.Heal(enemy);
player.DisplayCharacterInfo();
enemy.DisplayCharacterInfo();

enemy.Attack(player);
player.Attack(enemy);
player.DisplayCharacterInfo();
enemy.DisplayCharacterInfo();


Story.ReactionScene();
