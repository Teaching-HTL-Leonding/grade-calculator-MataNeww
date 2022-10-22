Console.Write("Have you participated in the first exam? (yes/no):  ");
string answer = Console.ReadLine()!;

int points = 0;
int maxpoints= 0;

if (answer == "yes")
{
    Console.Write("How many points do you had in the first exam? (0-20): ");
    maxpoints+= 20;
    points += int.Parse(Console.ReadLine()!);
    Console.WriteLine("");
}
else Console.Write("");

Console.Write("Have you participated in the second exam? (yes/no):  ");
string answer2 = Console.ReadLine()!;
if (answer2 == "yes")
{
    Console.Write("How many points do you had in the second exam? (0-20): ");
    maxpoints+= 20;
    points += int.Parse(Console.ReadLine()!);
    Console.WriteLine("");
}

//Level 2
Console.Write("How many points did you got through homework? (0-20): ");
maxpoints+= 20;
int homeworkPoints = int.Parse(Console.ReadLine()!);
Console.WriteLine("");

//Level 3
Console.Write("Have you done an oral exam? (yes/no): ");
string answer4 = Console.ReadLine()!;
if (answer4 == "yes")
{
    Console.Write("How many points do you had in the exam? (0-20): ");
    maxpoints+= 20;
    points += int.Parse(Console.ReadLine()!);
    Console.WriteLine("");
}

int percent = 100 * (points + homeworkPoints) / maxpoints;
int possiblepercent = 100 * (points + 20) / maxpoints;


if(percent >= 89 && possiblepercent >=89)
{
    Console.WriteLine("Note: 1");
}
else if (percent >= 76 && possiblepercent >= 76)
{
    Console.WriteLine("Note: 2");
    Console.WriteLine("But you could have gotten a better grade if you had done the homework!)");
}
else if (percent >= 63 && possiblepercent >=63)
{
    Console.WriteLine("Note: 3");
    Console.WriteLine("But you could have gotten a better grade if you had done the homework!)");
}
else if (percent >= 50 && possiblepercent >= 50)
{
    Console.WriteLine("Note: 4");
    Console.WriteLine("But you could have gotten a better grade if you had done the homework!)");
}
else 
{
    Console.WriteLine("Note: 5");
    Console.WriteLine("But you could have gotten a better grade if you had done the homework!)");
}


