namespace ConsoleRPG
{
    public static class Story
    {
        static private List<string> Scene = new List<string>();

        public static void ScenesSetup()
        {
            Scene.Add("Welcome to ConsoleRPG A .NET 6 C# RPG Adventure");
            Scene.Add("How will you respond? Run or Attack?");
        }
        public static void StartScene()
        {
            Console.WriteLine(Scene[0]);
        }
        public static void ReactionScene()
        {
            Console.WriteLine(Scene[1]);
        }
    }
}
