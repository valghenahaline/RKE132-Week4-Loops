

Console.WriteLine("Guess the number");

Random rnd = new Random();
int cpuRandom;

bool loopActive = true;
while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);

    Console.WriteLine("Guess the number between 1-3");

    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("YAY, YOU WON!");

        loopActive = false;
        // saab ka kasutada break;
    }
    else
    {
        Console.WriteLine("Wrong number ;( . Try again!");
    }
}

Console.WriteLine("See you next time!");