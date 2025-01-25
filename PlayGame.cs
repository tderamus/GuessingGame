public class PlayGame
{
    Random random = new Random();
    int SecretNumber;
    int userGuess;

    public void StartGame()
    {
        UserLevel userLevel = new UserLevel();
        userLevel.GetUserLevel();

        int attempts = userLevel.Attempts;

        SecretNumber = random.Next(1, 101);

        Console.WriteLine("Guess the secret number between 1 and 100");
        while (userGuess != SecretNumber && attempts > 0)
        {
            userGuess = Convert.ToInt32(Console.ReadLine());

            for (int Counter = 0; Counter < userLevel.Attempts; Counter++)
            {
                int userTries = (userLevel.Attempts -1) - Counter;
                if (userGuess == SecretNumber)
                {
                    Console.WriteLine($"Congratulations, the secret number is {SecretNumber}, your guess {userGuess} is correct!");
                    StartGame();
                }
                else if ( userGuess != SecretNumber && userTries == 0)
                {
                    Console.WriteLine($"\nSorry, you have exhausted all your tries. \nThe secret number is {SecretNumber}");
                    StartGame();
                }
                else
                {
                    Console.WriteLine($"\nSorry, your guess is incorrect! Please try again. \nYou have {userTries} tries remaining.");
                    UserOutcome(userGuess);
                    Console.WriteLine();
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    
                }
            }
        }
    }

    void UserOutcome(int userGuess)
    {
        if (userGuess > SecretNumber)
        {
            Console.WriteLine($"\nYour guess {userGuess} is higher than the secret number!");
        }
        else
        {
            Console.WriteLine($"\nYour guess {userGuess} is lower than the secret number!");
        }
    }
}
