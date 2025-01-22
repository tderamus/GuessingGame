string greeting = "Welcome To The Number Guessing Game!";
Console.WriteLine(greeting);


UserLevel userLevel = new UserLevel();
userLevel.GetUserLevel();


PlayGame playGame = new PlayGame(userLevel);
playGame.StartGame(userLevel.Attempts);