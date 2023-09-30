namespace Projekt_na_zaliczenie
{
    public interface IFirefighter
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }

        void AddGradePullUps(float grade);
        void AddGradePullUps(string grade);

        void AddGradeBeepTest(float grade);
        void AddGradeBeepTest(string grade);

        void AddGradeEnvelope(float grade);
        void AddGradeEnvelope(string grade);
        Statistics GetStatistics();

    }
}
