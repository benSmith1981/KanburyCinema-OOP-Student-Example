﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//test comment
namespace KanburyCinema
{
    class Movie
    {
        private string name;
        private string certificate;
        private string director;
        private string mainStar;
        private int runningTime;

        public Movie(string name, string certificate, string director, string mainStar, int runningTime)
        {
            this.name = name;
            this.certificate = certificate;
            this.director = director;
            this.mainStar = mainStar;
            this.runningTime = runningTime;
        }

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        publice string Certificate
        {
            get { return certificate }

            set { certificate = value; }
        }

        public string Director
        {
            get { return director; }

            set { director = valve; }
        }

        public string MainStar
        {
            get { return mainStar; }

            set { director = value; }
        }

        public string RunningTime
        {
            get { return runningTime; }

            set { runningTime = value; }
        }
    }
}
