using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_na_zaliczenie
{
    public class FirefighterInFile : BaseFile
    {
        private List<float> scoreBeebTest = new List<float>();

        private List<float> scorePullUps = new List<float>();

        private List<float> scoreEnvelope = new List<float>();

        private const string fileNamePullUps = "gradesPullUps.txt";
        private const string fileNameBeepTest = "gradesBeepTest.txt";
        private const string fileNameEnvelope = "gradesEnvelope.txt";

        public override event GradeAddedDelegate GradeAdded;
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public FirefighterInFile(string name, string surname, int age) :
            base(name, surname, age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public override void AddGradePullUps(float grade)
        {
            if (grade >= 0 && grade <= 26)
            {
                using (var writer = File.AppendText(fileNamePullUps))
                {
                    writer.WriteLine(grade);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid score value");
            }
        }

        public override void AddGradePullUps(string grade)
        {
            if (float.TryParse(grade, out float number))
            {
                this.AddGradePullUps(number);
            }
            else
            {
                throw new Exception("Incorrect value");
            }
        }

        public override void AddGradeBeepTest(float grade)
        {
            if (grade >= 0 && grade <= 12.5)
            {
                using (var writer = File.AppendText(fileNameBeepTest))
                {
                    writer.WriteLine(grade);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid score value");
            }
        }

        public override void AddGradeBeepTest(string grade)
        {
            if (float.TryParse(grade, out float number))
            {
                this.AddGradeBeepTest(number);
            }
            else
            {
                throw new Exception("Incorrect value");
            }
        }

        public override void AddGradeEnvelope(float grade)
        {
            if (grade >= 0 && grade <= 22)
            {
                using (var writer = File.AppendText(fileNameEnvelope))
                {
                    writer.WriteLine(grade);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid score value");
            }
        }

        public override void AddGradeEnvelope(string grade)
        {
            if (float.TryParse(grade, out float number))
            {
                this.AddGradeEnvelope(number);
            }
            else
            {
                throw new Exception("Incorrect value");
            }
        }

        public override Statistics GetStatistics()
        {
            var scorePullUpsFromFile = this.ReadGradesFromFilePullUps();
            var scoreBeepTestFromFile = this.ReadGradesFromFileBeepTest();
            var scoreEnvelopeFromFile = this.ReadGradesFromFileEnvelope();
            var result = this.CountStatisticsPullUps(scorePullUpsFromFile);
            var result2 = this.CountStatisticsBeepTest(scoreBeepTestFromFile);
            var result3 = this.CountStatisticsBeepTest(scoreEnvelopeFromFile);
            return result;
        }

        private Statistics CountStatisticsPullUps(List<float> grades)
        {
            var statistics = new Statistics();
            foreach (var grade in grades)
            {
                statistics.AddScorePullUps(grade);
            }
            return statistics;
        }
        private Statistics CountStatisticsBeepTest(List<float> grades)
        {
            var statistics = new Statistics();
            foreach (var grade in grades)
            {
                statistics.AddScoreBeepTest(grade);
            }
            return statistics;
        }
        private Statistics CountStatisticsEnvelope(List<float> grades)
        {
            var statistics = new Statistics();
            foreach (var grade in grades)
            {
                statistics.AddScoreEnvelope(grade);
            }
            return statistics;
        }
        private List<float> ReadGradesFromFilePullUps()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileNamePullUps}"))
            {
                using (var reader = File.OpenText($"{fileNamePullUps}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
        private List<float> ReadGradesFromFileBeepTest()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileNameBeepTest}"))
            {
                using (var reader = File.OpenText($"{fileNameBeepTest}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
        private List<float> ReadGradesFromFileEnvelope()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileNameEnvelope}"))
            {
                using (var reader = File.OpenText($"{fileNameEnvelope}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
    }
}
