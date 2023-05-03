/*
 * Create a static method to generate the random numbers.
Proper method header: 2 points
Program generates random numbers validly within the user-specified range: 1 point
Method returns meaningful value of proper type: 1 point


* Create a static method for six-sided dice that takes two dice values as parameters, 
and returns a string for one of the valid combinations (e.g. Snake Eyes, etc.) 
or an empty string if the dice don’t match one of the combinations.
Snake Eyes: Two 1s
Ace Deuce: A 1 and 2
Box Cars: Two 6s
Or empty string if no matching combos


* Create a static method for six-sided dice that takes two dice values as parameters, 
and returns a string for one of the valid totals (e.g. Win, etc.) or an empty string if the dice don’t match one of the totals.
Win: A total of 7 or 11
Craps: A total of 2, 3, or 12
Or empty string if no matching combos
Application takes all user input correctly: 1 point
Application loops properly: 1 point
*/
string keepGoing;
do
{
    Console.WriteLine("Welcome to the Grand Circus Casino!");

    Console.WriteLine("How many sides should each die have?");
    int input = int.Parse(Console.ReadLine());
    Console.WriteLine(PlayOne(GenerateRandom(input), GenerateRandom(input)));
    Console.WriteLine(PlayTwo(GenerateRandom(input), GenerateRandom(input)));

    Console.WriteLine("Do you want to continue? y/n?");
    keepGoing = Console.ReadLine();

    if(keepGoing == "n")
    {
        Console.WriteLine("GoodBye!");
    }

} while (keepGoing == "y");

static int GenerateRandom(int input)
{
    return new Random().Next(1, input + 1);
}
static string PlayOne(int num1, int num2)
{
    int total = num1 + num2;
    Console.WriteLine("Roll 1:");
    Console.WriteLine($"You rolled {num1} and {num2} (total: {total})");
    if (num1 == 1 && num2 == 1)
    {
        return "Snake Eyes!";
    }
    else if (num1 == 1 || num1 == 2 && num2 == 1 || num2 == 2)
    {
        return "Ace Deuce!";
    } else if(num1 == 6 && num2 == 6)
    {
        return "Box Cars!";
    } else
    {
        return "You Lose";
    }
   
}
static string PlayTwo(int num1, int num2)
{
    int total = num1 + num2;
    Console.WriteLine("Roll 2:");
    Console.WriteLine($"You rolled {num1} and {num2} (total: {total})");
    if (total == 7 || total == 11)
    {
        return "win";
    } else if(total == 2 || total == 3 || total == 12)
    {
       return "craps";
    } else 
    {
        return "You Lose";

    }
}