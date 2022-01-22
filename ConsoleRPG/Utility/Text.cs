using ConsoleRPG.Characters;

namespace ConsoleRPG.Utility
{
    public class Text
    {
        public static void GameStartMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
            ///////////////////////////////////
            ///     C# ConsoleRPG Game      ///
            ///     Classic Old School      ///
            ///      Text Based Game        ///    
            ///////////////////////////////////
            "); 
        }

        public static void CharacterInfo(Character character)
        {
            Console.WriteLine($"Character Info Name: {character.Name}. Level: {character.Level}. HitPoints: {character.HitPoints}. Coins {character.Coins} ");
        }
        public static void ParseInputToInt(string input)
        {
            bool success = int.TryParse(input, out int result);
            if (success)
            {
                Console.WriteLine($"Converted string {input} to number int {result}");
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{input ?? "<null>"}' failed'");
            }
            //Console.Clear();
        }
    }
}
