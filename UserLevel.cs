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
    };

    public void GetUserLevel()
    {

        bool Exit = false;

        Console.WriteLine("\nSelect a level to play");
        foreach (UserLevel level in userLevels)
        {
            Console.WriteLine($"{level.Level}. {level.LevelName}");
        }
        Level = Convert.ToInt32(Console.ReadLine());

        switch (Level)
        {case 1:
                Console.WriteLine($"\nYou have selected Easy Level. \nYou have {userLevels[Level - 1].Attempts} attempts to guess the number.");
                break;
            case 2:
                Console.WriteLine($"\nYou have selected Medium Level. \nYou have {userLevels[Level - 1].Attempts} attempts to guess the number.");
                Attempts = 6;
                break;
            case 3:
                Console.WriteLine($"\nYou have selected Hard Level. \nYou have {userLevels[Level - 1].Attempts} attempts to guess the number.");
                Attempts = 4;
                break;
            default:
                Console.WriteLine("\nInvalid selection. Please select a valid level");
                GetUserLevel();
                break;


        }

    }
}
