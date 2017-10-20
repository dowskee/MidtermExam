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
        public NascarCar(string vnnum, string makename, string tmnm)
        {
            VIN = vnnum;
            Make = makename;
            TeamName = tmnm;
        }

        public override void PrintInfo() //print info method override Car class to print variables + TeamName
        {
            Console.WriteLine(VIN.PadRight(10, ' ') + "\t" + Make.PadRight(10, ' ') + "\t" + TeamName);
        }

        public override string ToString() //implement ToString for future printing
        {
            return (VIN.PadRight(10, ' ') + "\t" + Make.PadRight(10, ' ') + "\t" + TeamName); //added padding for better display
        }

    }
}
