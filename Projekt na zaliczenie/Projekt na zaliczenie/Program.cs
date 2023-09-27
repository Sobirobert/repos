using Projekt_na_zaliczenie;
using System.Diagnostics;

Console.WriteLine("Witamy w Programie do oceny testów sprawnościowych strażaków w służbie stałej");
Console.WriteLine("========================================================");
Console.WriteLine();

Console.WriteLine("Podaj imię strażaka");
var name = Console.ReadLine();

Console.WriteLine("Podaj nazwisko strażaka");
var surname = Console.ReadLine();

Console.WriteLine("Podaj wiek strażaka");
var age = Console.ReadLine();
int ageInt = 0;
if (int.TryParse(age, out int number))
{
    ageInt = number;
}
else
{
    throw new Exception("Incorrect value");
}


var firefighter = new FirefighterInFile(name, surname, ageInt);

firefighter.GradeAdded += EmployeeGradeAdded;
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano wynik.");
}

Console.WriteLine($"Name: {firefighter.Name}, Surname: {firefighter.Surname}, Age: {firefighter.Age}");

while (true)
{
    Console.WriteLine("Podaj wyniki z testów sprawnościowych strażaka");
    Console.WriteLine(@"Aby wyjść kliknij 'q', albo kontynuuj");
    Console.WriteLine(@"Aby podać wynik z podciągania wciśnij 1 ");
    Console.WriteLine(@"Aby podać wynik z beeptestu wciśnij 2 ");
    Console.WriteLine(@"Aby podać wynik z koperty wciśnij 3 ");
    Console.WriteLine(@"Aby wyświetlić statystki wciśnij 4 ");
    var inPut = Console.ReadLine();
    try
    {
        switch (inPut)
        {
            case "q":
                return;
            case "1":
                Console.WriteLine("Wynik z podciągania");
                var pushUps = Console.ReadLine();
                firefighter.AddGradePullUps(pushUps);
                break;
            case "2":
                Console.WriteLine("Wynik z BeepTest");
                var beepTest = Console.ReadLine();
                firefighter.AddGradeBeepTest(beepTest);
                break;
            case "3":
                Console.WriteLine("Wynik z Koperty");
                var envelope = Console.ReadLine();
                firefighter.AddGradeEnvelope(envelope);
                break;
            case "4":
                var statistics = firefighter.GetStatistics();
                Console.WriteLine($" Podciąganie: {statistics.ScorePullUps}");
                Console.WriteLine($" BeepTest: {statistics.ScoreBeepTest}");
                Console.WriteLine($" Koperta: {statistics.ScoreEnvelope}");
                Console.WriteLine($" Średnia z 3 ocen wynosi: {statistics.Average}");
                Console.WriteLine($" Końcowa ocena jaką strażak uzyskał z testów sprawności fizycznej wynosi: {statistics.EndRating}");
                statistics.DisplayStatictic();
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exeption catched: {e.Message}");
    }
}




