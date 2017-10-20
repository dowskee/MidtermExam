using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExam
{
    class NascarCar:Car //implement inheritence
    {
        //variables
        private string TeamName;

        //properties
        public string teamname
        {
            set { teamname = value; }
            get { return teamname; }
        }

        //base constructor
        public NascarCar()
        {
            teamname = "";
        }
        //overloaded constructor to initialize variables
        public NascarCar(string tmnm)
        {
            TeamName = tmnm;
        }

        public override void PrintInfo() //print info method override Car class to print variables + TeamName
        {
            Console.WriteLine(VIN + Make + TeamName);
        }
    }
}
