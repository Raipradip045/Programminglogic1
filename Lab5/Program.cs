namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        // Problem season 0f the year
string[] seasons = { "Spring", "Summer", "Fall", "winter" };
foreach (string season in seasons)
    Console.WriteLine("season:"+ season);

// problem 2 Day of the week 1-7
string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "saturday", "Sunday" };
 Console.Write("Enter a number (1-7): ");

string input = Console.ReadLine();

if (int.TryParse(input, out int dayNumber))
    if (dayNumber >= 1 && dayNumber <= 7)
        Console.WriteLine($"that day is:{days[dayNumber - 1]}");
    else
    {
        Console.WriteLine("invalid input. Please enter a number between 1 and 7.");
    }
else
    Console.WriteLine("Invalid input. Please enter a numeric value.");
Console.WriteLine();

// Problem 3 favorite Books and Authors

String[] books = { "To Kill the Mokingbirds", "The great gatsby", "The lord of the rings", };
String[] authors = { "Harper lee", "F.Scott Fitzerald", "john Ronald" };

for(int i = 0; i < books.Length; i++)  
    Console.WriteLine($"{books[i]}) by {authors[i]}");

// problem 4
int[] temperatures = { 65, 72, 78, 70, 68 };
Array.Sort(temperatures);
Console.Write("sorted Temperatures:");
foreach (int temp in temperatures)
    Console.Write(temp + "");
Console.WriteLine();
int highestTemperature = temperatures[temperatures.Length - 1];
int lowestTemperature = temperatures[0];
Console.WriteLine("Highestt Temperature:" + highestTemperature);
Console.WriteLine("Lowest temperature:" + lowestTemperature);

// Problem 5

int[] countdown = { 5, 4, 3, 2, 1 };
Array.Reverse(countdown);
Console.WriteLine("Countdown:");
for (int i = 0; i < countdown.Length;i++)
{ 
Console.Write(countdown[i] + "");
}

    }
}
