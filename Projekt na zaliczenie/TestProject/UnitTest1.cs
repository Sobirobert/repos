using Projekt_na_zaliczenie;

namespace TestProject
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            void GetUserAndScoreShouldReturnPullUps()
            {
                //arange
                var firefighter = new Firefighter("Adam", "Wick", 34);
                firefighter.AddGradeBeepTest(11.4f);
                firefighter.AddGradePullUps(24);
                firefighter.AddGradeEnvelope(22);
                //act
                var statistics = firefighter.GetStatistics();

                //assert    
                Assert.AreEqual(24, statistics.RatingPullUps);
            }
            void GetUserAndScoreShouldReturnBeepTest()
            {
                //arange
                var firefighter = new Firefighter("Adam", "Wick", 34);
                firefighter.AddGradeBeepTest(10.4f);
                firefighter.AddGradePullUps(26);
                firefighter.AddGradeEnvelope(22.4f);
                //act
                var statistics = firefighter.GetStatistics();

                //assert    
                Assert.AreEqual(10.4f, statistics.RatingBeepTest);

            }
            void GetUserAndScoreShouldReturnEnvelope()
            {
                //arange
                var firefighter = new Firefighter("Adam", "Wick", 34);
                firefighter.AddGradeBeepTest(10.4f);
                firefighter.AddGradePullUps(26);
                firefighter.AddGradeEnvelope(22.4f);
                //act
                var statistics = firefighter.GetStatistics();

                //assert    
                Assert.AreEqual(22.4f, statistics.RatingEnvelope);

            }
            void GetUserAndScoreShouldReturnAverage()
            {
                //arange
                var firefighter = new Firefighter("Adam", "Wick", 34);
                firefighter.AddGradeBeepTest(12.5f);
                firefighter.AddGradePullUps(26);
                firefighter.AddGradeEnvelope(22f);
                //act
                var statistics = firefighter.GetStatistics();

                //assert    
                Assert.AreEqual(75, statistics.Average);

            }

        }
    }
}