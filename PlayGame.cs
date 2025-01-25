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
                    Console.WriteLine($"Congratulations, your guess {userGuess} is correct!");
                    break;
                }
                else if ( userGuess != SecretNumber && userTries == 0)
                {
                    Console.WriteLine($"\nSorry, you have exhausted all your tries. \nThe secret number is {SecretNumber}");
                    StartGame();
                }
                else
                {
                    UserOutcome(userGuess);
                    Console.WriteLine($"Sorry, your guess is incorrect! Please try again. \nYou have {userTries} tries remaining.");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    
                }
            }
        }
    }

    void UserOutcome(int userGuess)
    {
        if (userGuess > SecretNumber)
        {
            Console.WriteLine($"Your guess {userGuess} is higher than the secret number!");
        }
        else
        {
            Console.WriteLine($"Your guess {userGuess} is lower than the secret number!");
        }
    }
}
