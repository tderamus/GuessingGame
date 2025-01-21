string greeting = "Welcome To The Number Guessing Game! \n\nGuess a number to play. \nYou have four attempts to guess the number.";
Console.WriteLine(greeting);

int userGuess = Convert.ToInt32(Console.ReadLine()); 

int SecretNumber = 42;



for (int Counter = 0; Counter < 3; Counter++)
{
    int userTries = 3 - Counter;
    if (userGuess == SecretNumber)
    {
        Console.WriteLine($"Congratulations, your guess {userGuess} is correct!");
        break;
    }
    else
    {
        Console.WriteLine($"So sorry, your guess {userGuess} is incorrect! Please try again. \nYou have {userTries} tries remaining.");
        userGuess = Convert.ToInt32(Console.ReadLine());
    }
}
