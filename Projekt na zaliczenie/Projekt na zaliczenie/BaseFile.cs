using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_na_zaliczenie
{
    public abstract class BaseFile : IFirefighter
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public BaseFile(string name, string surname, int age) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public abstract void AddGradePullUps(float grade);
        public abstract void AddGradePullUps(string grade);

        public abstract void AddGradeBeepTest(float grade);
        public abstract void AddGradeBeepTest(string grade);

        public abstract void AddGradeEnvelope(float grade);
        public abstract void AddGradeEnvelope(string grade);

        public abstract Statistics GetStatistics();
    }
}
