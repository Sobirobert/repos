﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_na_zaliczenie
{
    public interface IFirefighter
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }

        void AddGradePushUps(float grade);
        void AddGradePushUps(string grade);

        void AddGradeBeepTest(float grade);
        void AddGradeBeepTest(string grade);

        void AddGradeEnvelope(float grade);
        void AddGradeEnvelope(string grade);
        Statistics GetStatistics();

    }
}
