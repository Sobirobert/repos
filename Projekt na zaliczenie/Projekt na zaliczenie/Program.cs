using Projekt_na_zaliczenie;
using System.Diagnostics;

Console.WriteLine("Welcome to the Program for assessing fitness tests for firefighters in permanent service.");
Console.WriteLine("========================================================");
Console.WriteLine();

Console.WriteLine("Enter name of firefighter.");
var name = Console.ReadLine();

Console.WriteLine("Enter surname of firefighter.");
var surname = Console.ReadLine();

Console.WriteLine("Enter age of firefighter.");
var userInPut = Console.ReadLine();
int age = 0;
if (int.TryParse(userInPut, out int number))
{
    age = number;
}
else
{
    throw new Exception("Incorrect value");
}


var firefighter = new FireFighter(name, surname, age);

firefighter.GradeAdded += EmployeeGradeAdded;
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Result added.");
}

Console.WriteLine($"Name: {firefighter.Name}, Surname: {firefighter.Surname}, Age: {firefighter.Age}");

while (true)
{
    Console.WriteLine("Enter your firefighter fitness test results");
    Console.WriteLine();
    Console.WriteLine(@"To exit click 'q' or continue");
    Console.WriteLine();
    Console.WriteLine(@"To enter the pull-up result, press 1 ");
    Console.WriteLine();
    Console.WriteLine(@"To enter the beeptest result, press 2 ");
    Console.WriteLine();
    Console.WriteLine(@"To enter the result from the envelope, press 3 ");
    Console.WriteLine();
    Console.WriteLine(@"To view statistics, press 4 ");
    Console.WriteLine();
    var inPut = Console.ReadLine();
    try
    {
        switch (inPut)
        {
            case "q":
                return;
            case "1":
                Console.WriteLine("Pull-ups result");
                var pushUps = Console.ReadLine();
                firefighter.AddGradePullUps(pushUps);
                break;
            case "2":
                Console.WriteLine("Result from BeepTest");
                var beepTest = Console.ReadLine();
                firefighter.AddGradeBeepTest(beepTest);
                break;
            case "3":
                Console.WriteLine("Result from the Envelope run");
                var envelope = Console.ReadLine();
                firefighter.AddGradeEnvelope(envelope);
                break;
            case "4":
                var statistics = firefighter.GetStatistics();

                statistics.DisplayStatictic();
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exeption catched: {e.Message}");
    }
}




