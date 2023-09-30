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
        public void AddGradePullUps(string grade)
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

        public abstract void AddGradeBeepTest(float grade);
        public void AddGradeBeepTest(string grade)
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

        public abstract void AddGradeEnvelope(float grade);
        public void AddGradeEnvelope(string grade)
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

        public abstract Statistics GetStatistics();
    }
}
