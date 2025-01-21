string greeting = "Welcome To The Number Guessing Game! \n\nGuess a number to play. \nYou have four attempts to guess the number.";
Console.WriteLine(greeting);

int userGuess = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int SecretNumber = random.Next(1, 101);


for (int Counter = 0; Counter < 3; Counter++)
{
    int userTries = 3 - Counter;
    if (userGuess == SecretNumber)
    {
        Console.WriteLine($"Congratulations, your guess is correct!");
        //UserOutcome(userGuess, SecretNumber);
        break;
    }
    else
    {
        Console.WriteLine($"So sorry, your guess is incorrect! Please try again. \nYou have {userTries} tries remaining.");
        UserOutcome(userGuess, SecretNumber);
        userGuess = Convert.ToInt32(Console.ReadLine());
    }
}

void UserOutcome(int userGuess, int SecretNumber)
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