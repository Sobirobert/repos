using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_na_zaliczenie
{
    public class Firefighter : BaseFile
    {
        private List<float> scoreBeebTest = new List<float>();

        private List<float> scorePullUps = new List<float>();

        private List<float> scoreEnvelope = new List<float>();

        public override event GradeAddedDelegate GradeAdded;
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public Firefighter(string name, string surname, int age):
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
                this.scorePullUps.Add(grade);
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
                this.scoreBeebTest.Add(grade);
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
                this.scoreEnvelope.Add(grade);
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
            var statistics = new Statistics();
            foreach (var score in this.scorePullUps)
            {
                statistics.AddScorePullUps(score);
            }
            foreach (var score in this.scoreBeebTest)
            {
                statistics.AddScoreBeepTest(score);
            }
            foreach (var score in this.scoreEnvelope)
            {
                statistics.AddScoreEnvelope(score);
            }
            return statistics;
        }
    }
}