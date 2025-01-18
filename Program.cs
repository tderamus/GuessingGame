string greeting = "Welcome to the Number guessing game! \n\nGUESS A NUMBER TO PLAY";
Console.WriteLine(greeting);

int userGuess = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine($"\nYour guess was {userGuess} !");