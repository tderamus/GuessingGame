string greeting = "Welcome to the Number guessing game! \n\nGUESS A NUMBER TO PLAY. \nYou have four attempts to guess the number.";
Console.WriteLine(greeting);

int userGuess = Convert.ToInt32(Console.ReadLine()); 

int SecretNumber = 42;



for (int Counter = 0; Counter < 3; Counter++)
{
    int userTries = 3 - Counter;
    if (userGuess == SecretNumber)
    {
        Console.WriteLine("Congratulations, your guess is correct!");
        break;
    }
    else
    {
        Console.WriteLine($"So sorry, you guessed the wrong number! \nPlease try again. \nYou have {userTries} tries remaining.");
        userGuess = Convert.ToInt32(Console.ReadLine());
    }
}
