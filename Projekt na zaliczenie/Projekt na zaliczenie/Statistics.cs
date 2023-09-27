using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Projekt_na_zaliczenie
{
    public class Statistics 
    { 
        public float ScorePullUps { get; private set; }
        public float ScoreBeepTest { get; private set; }
        public float ScoreEnvelope { get; private set; }
        public int RatingPullUps
        {
            get
            {
                switch (this.ScorePullUps)
                {
                    case var score when score == 26:
                        return 75;
                    case var score when score == 25:
                        return 74;
                    case var score when score == 24:
                        return 73;
                    case var score when score == 23:
                        return 72;
                    case var score when score == 22:
                        return 71;
                    case var score when score == 21:
                        return 70;
                    case var score when score == 20:
                        return 69;
                    case var score when score == 19:
                        return 68;
                    case var score when score == 18:
                        return 67;
                    case var score when score == 17:
                        return 66;
                    case var score when score == 16:
                        return 65;
                    case var score when score == 15:
                        return 63;
                    case var score when score == 14:
                        return 61;
                    case var score when score == 13:
                        return 58;
                    case var score when score == 12:
                        return 55;
                    case var score when score == 11:
                        return 50;
                    case var score when score == 10:
                        return 45;
                    case var score when score == 9:
                        return 40;
                    case var score when score == 8:
                        return 35;
                    case var score when score == 7:
                        return 30;
                    case var score when score == 6:
                        return 25;
                    case var score when score == 5:
                        return 20;
                    case var score when score == 4:
                        return 15;
                    case var score when score == 3:
                        return 10;
                    case var score when score == 2:
                        return 5;
                    default:
                        return 1;
                }
            }
        }
        public float RatingBeepTest 
        {
            get
            {
                switch (this.ScoreBeepTest)
                {
                    case var score when score == 12.5f:
                        return 75;
                    case var score when score == 12.4f:
                        return 74;
                    case var score when score == 12.3f:
                        return 73;
                    case var score when score == 12.2f:
                        return 72;
                    case var score when score == 12.1f:
                        return 71;
                    case var score when score == 12f:
                        return 71;
                    case var score when score == 11.12f:
                        return 70;
                    case var score when score == 11.11f:
                        return 69;
                    case var score when score == 11.10f:
                        return 68;
                    case var score when score == 11.9f:
                        return 67;
                    case var score when score == 11.8f:
                        return 66;
                    case var score when score == 11.7f:
                        return 65;
                    case var score when score == 11.6f:
                        return 64;
                    case var score when score == 11.5f:
                        return 63;
                    case var score when score == 11.4f:
                        return 62;
                    case var score when score == 11.3f:
                        return 61;
                    case var score when score == 11.2f:
                        return 60;
                    case var score when score == 11.1f:
                        return 59;
                    case var score when score == 11f:
                        return 59;
                    case var score when score == 10.11f:
                        return 58;
                    case var score when score == 10.10f:
                        return 57;
                    case var score when score == 10.9f:
                        return 56;
                    case var score when score == 10.8f:
                        return 55;
                    case var score when score == 10.7f:
                        return 54;
                    case var score when score == 10.6f:
                        return 53;
                    case var score when score == 10.5f:
                        return 52;
                    case var score when score == 10.4f:
                        return 51;
                    case var score when score == 10.3f:
                        return 50;
                    case var score when score == 10.2f:
                        return 49;
                    case var score when score == 10.1f:
                        return 48;
                    case var score when score == 10f:
                        return 48;
                    case var score when score == 9.11f:
                        return 47;
                    case var score when score == 9.10f:
                        return 46;
                    case var score when score == 9.9f:
                        return 45;
                    case var score when score == 9.8f:
                        return 44;
                    case var score when score == 9.7f:
                        return 43;
                    case var score when score == 9.6f:
                        return 42;
                    case var score when score == 9.5f:
                        return 41;
                    case var score when score == 9.4f:
                        return 40;
                    case var score when score == 9.3f:
                        return 39;
                    case var score when score == 9.2f:
                        return 38;
                    case var score when score == 9.1f:
                        return 37;
                    case var score when score == 9f:
                        return 37;
                    case var score when score == 8.11f:
                        return 36;
                    case var score when score == 8.10f:
                        return 35;
                    case var score when score == 8.9f:
                        return 34;
                    case var score when score == 8.8f:
                        return 33;
                    case var score when score == 8.7f:
                        return 32;
                    case var score when score == 8.6f:
                        return 31;
                    case var score when score == 8.5f:
                        return 30;
                    case var score when score == 8.4f:
                        return 29;
                    case var score when score == 8.3f:
                        return 28;
                    case var score when score == 8.2f:
                        return 27;
                    case var score when score == 8.1f:
                        return 26;
                    case var score when score == 8f:
                        return 26;
                    case var score when score == 7.10f:
                        return 25;
                    case var score when score == 7.9f:
                        return 24;
                    case var score when score == 7.8f:
                        return 23;
                    case var score when score == 7.7f:
                        return 22;
                    case var score when score == 7.6f:
                        return 21;
                    case var score when score == 7.5f:
                        return 20;
                    case var score when score == 7.4f:
                        return 19;
                    case var score when score == 7.3f:
                        return 18;
                    case var score when score == 7.2f:
                        return 17;
                    case var score when score == 7.1f:
                        return 16;
                    case var score when score == 7f:
                        return 16;
                    case var score when score == 6.10f:
                        return 15;
                    case var score when score == 6.9f:
                        return 14;
                    case var score when score == 6.8f:
                        return 13;
                    case var score when score == 6.7f:
                        return 12;
                    case var score when score == 6.6f:
                        return 11;
                    case var score when score == 6.5f:
                        return 10;
                    case var score when score == 6.4f:
                        return 9;
                    case var score when score == 6.3f:
                        return 8;
                    case var score when score == 6.2f:
                        return 7;
                    case var score when score == 6.1f:
                        return 6;
                    case var score when score == 6f:
                        return 6;
                    case var score when score == 5.9f:
                        return 5;
                    case var score when score == 5.8f:
                        return 4;
                    case var score when score == 5.7f:
                        return 3;
                    case var score when score == 5.6f:
                        return 2;
                    case var score when score == 5.5f:
                        return 1;
                    default:
                        return 0;
                    
                }
            }
        }
        public float RatingEnvelope 
        {
            get 
            {
                switch (this.ScoreEnvelope)
                {
                    case var score when score == 22f:
                        return 75;
                    case var score when score == 22.05f:
                        return 74;
                    case var score when score == 22.1f:
                        return 73;
                    case var score when score == 22.15f:
                        return 72;
                    case var score when score == 22.2f:
                        return 71;
                    case var score when score == 22.25f:
                        return 70;
                    case var score when score == 22.3f:
                        return 69;
                    case var score when score == 22.35f:
                        return 68;
                    case var score when score == 22.4f:
                        return 67;
                    case var score when score == 22.45f:
                        return 66;
                    case var score when score == 22.5f:
                        return 65;
                    case var score when score == 22.55f:
                        return 64;
                    case var score when score == 22.6f:
                        return 63;
                    case var score when score == 22.65f:
                        return 62;
                    case var score when score == 22.7f:
                        return 61;
                    case var score when score == 22.75f:
                        return 60;
                    case var score when score == 22.8f:
                        return 59;
                    case var score when score == 22.85f:
                        return 58;
                    case var score when score == 22.9f:
                        return 57;
                    case var score when score == 22.95f:
                        return 56;
                    case var score when score == 23f:
                        return 55;
                    case var score when score == 23.05f:
                        return 54;
                    case var score when score == 23.1f:
                        return 53;
                    case var score when score == 23.15f:
                        return 52;
                    case var score when score == 23.2f:
                        return 51;
                    case var score when score == 23.25f:
                        return 50;
                    case var score when score == 23.30f:
                        return 49;
                    case var score when score == 23.35f:
                        return 48;
                    case var score when score == 23.4f:
                        return 47;
                    case var score when score == 23.45f:
                        return 46;
                    case var score when score == 23.5f:
                        return 45;
                    case var score when score == 23.6f:
                        return 44;
                    case var score when score == 23.7f:
                        return 43;
                    case var score when score == 23.8f:
                        return 42;
                    case var score when score == 23.9f:
                        return 41;
                    case var score when score == 24f:
                        return 40;
                    case var score when score == 24.1f:
                        return 39;
                    case var score when score == 24.2f:
                        return 38;
                    case var score when score == 24.3f:
                        return 37;
                    case var score when score == 24.4f:
                        return 36;
                    case var score when score == 24.5f:
                        return 35;
                    case var score when score == 24.6f:
                        return 34;
                    case var score when score == 24.7f:
                        return 33;
                    case var score when score == 24.8f:
                        return 32;
                    case var score when score == 24.9f:
                        return 31;
                    case var score when score == 25f:
                        return 30;
                    case var score when score == 25.1f:
                        return 29;
                    case var score when score == 25.2f:
                        return 28;
                    case var score when score == 25.3f:
                        return 27;
                    case var score when score == 25.4f:
                        return 26;
                    case var score when score == 25.5f:
                        return 25;
                    case var score when score == 25.6f:
                        return 24;
                    case var score when score == 25.7f:
                        return 23;
                    case var score when score == 25.8f:
                        return 22;
                    case var score when score == 25.9f:
                        return 21;
                    case var score when score == 26f:
                        return 20;
                    case var score when score == 26.1f:
                        return 19;
                    case var score when score == 26.2f:
                        return 18;
                    case var score when score == 26.3f:
                        return 17;
                    case var score when score == 26.4f:
                        return 16;
                    case var score when score == 26.5f:
                        return 15;
                    case var score when score == 26.6f:
                        return 14;
                    case var score when score == 26.7f:
                        return 13;
                    case var score when score == 26.8f:
                        return 12;
                    case var score when score == 26.9f:
                        return 11;
                    case var score when score == 27f:
                        return 10;
                    case var score when score == 27.1f:
                        return 9;
                    case var score when score == 27.2f:
                        return 8;
                    case var score when score == 27.3f:
                        return 7;
                    case var score when score == 27.4f:
                        return 6;
                    case var score when score == 27.5f:
                        return 5;
                    case var score when score == 27.6f:
                        return 4;
                    case var score when score == 27.7f:
                        return 3;
                    case var score when score == 27.8f:
                        return 2;
                    case var score when score == 27.9f:
                        return 1;
                    default:
                        return 0;

                }
            }
        }
        public float SumRating
        {
            get
            {
                return RatingPullUps + RatingBeepTest + RatingEnvelope;
            }
        }
        public float Average
        {
            get
            {
                return SumRating / 3;
            }
        }
        public int EndRating
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average > 60:
                        return 6;
                    case var average when average > 55:
                        return 5;
                    case var average when average > 50:
                        return 4;
                    case var average when average > 45:
                        return 3;
                    case var average when average > 40:
                        return 2;
                    default:
                        return 1;
                }
            }
        }

        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 80:
                        return 'A';
                    case var average when average >= 60:
                        return 'B';
                    case var average when average >= 40:
                        return 'C';
                    case var average when average >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            ScorePullUps = float.MinValue;
            ScoreEnvelope = float.MaxValue;
            ScoreBeepTest = float.MinValue; 
        }
        public void AddScorePullUps(float pushUps)
        {
            this.ScorePullUps = Math.Max(pushUps, this.ScorePullUps);
        }
        public void AddScoreBeepTest(float beeptest)
        {
            this.ScoreBeepTest = Math.Max(beeptest, this.ScoreBeepTest);
        }
        public void AddScoreEnvelope(float envelope)
        {
            this.ScoreEnvelope = Math.Min(envelope, this.ScoreEnvelope);
        }
        public void DisplayStatictic()
        {
            Console.WriteLine($"Pull-Ups result: {ScorePullUps}, to daje {RatingPullUps} punktów");
            Console.WriteLine($"Beeptest result: {ScoreBeepTest}, to daje {RatingBeepTest} punktów");
            Console.WriteLine($"Envelope run result: {ScoreEnvelope}, to daje {RatingEnvelope} punktów");
            Console.WriteLine($"The average score from the 3 tests is: {Average}, this gives you the final grade {EndRating}");
            Console.WriteLine();
        }
    }
}
