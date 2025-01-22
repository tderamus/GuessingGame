public class UserLevel
{
    public int Level { get; set; }
    public string LevelName { get; set; }
    public int Attempts { get; set; }


    private static List<UserLevel> userLevels = new List<UserLevel>
    {
        new UserLevel { Level = 1, LevelName = "Easy - This gives the user 8 guesses", Attempts = 8 },
        new UserLevel { Level = 2, LevelName = "Medium - This gives the user 6 guesses", Attempts = 6 },
        new UserLevel { Level = 3, LevelName = "Hard - This gives the user 4 gueses", Attempts = 4 },
        new UserLevel { Level = 4, LevelName = "Default - This gives the user 4 gueses", Attempts = 4 },
        new UserLevel { Level = 5, LevelName = "Exit - Exit This Application" }
    };

    public void GetUserLevel()
    {

        bool Exit = false;
        Console.WriteLine("Select a level to play");
        foreach (UserLevel level in userLevels)
        {
            Console.WriteLine($"{level.Level}. {level.LevelName}");
        }
        Level = Convert.ToInt32(Console.ReadLine());

        if (Level < 1 || Level > 4)
        {
            Console.WriteLine("Invalid selection. Please select a valid level");
            GetUserLevel();
        }
        else
        {
            if (Level == 1)
            {
                Console.WriteLine("You have selected Easy Level. \nYou have 8 attempts to guess the number.");
                Attempts = 8;
            }
            else if (Level == 2)
            {
                Console.WriteLine("You have selected Medium Level. \nYou have 6 attempts to guess the number.");
                Attempts = 6;
            }
            else if (Level == 3)
            {
                Console.WriteLine("You have selected Hard Level. \nYou have 4 attempts to guess the number.");
                Attempts = 4;
            }
            else if (Level == 4)
            {
                Console.WriteLine("You have selected the default level. \nYou have 4 attempts to guess the number.");
                Attempts = 4;
            }
            else if (Level == 5)
            {
                Console.WriteLine("You have selected to exit the game. \nGoodbye!");
                Exit = true;
            }
        }

        PlayGame playGame = new PlayGame();
        playGame.StartGame(0);
    }
}
