public class PlayGame
{
    Random random = new Random();
    int SecretNumber;
    UserLevel userLevel;

    public PlayGame(UserLevel selectedLevel)
    {
        SecretNumber = random.Next(1, 101);
        userLevel = selectedLevel; // Assign the selected level to userLevel
    }

    public void StartGame(int userGuess)
    {
        for (int Counter = 0; Counter < userLevel.Attempts; Counter++)
        {
            int userTries = userLevel.Attempts - Counter;
            if (userGuess == SecretNumber)
            {
                Console.WriteLine($"Congratulations, your guess is correct!");
                break;
            }
            else
            {
                Console.WriteLine($"So sorry, your guess is incorrect! Please try again. \nYou have {userTries} tries remaining.");
                UserOutcome(userGuess);
                userGuess = Convert.ToInt32(Console.ReadLine());
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
