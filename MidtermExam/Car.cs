using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExam
{
    class Car
        //construct the following two classes: Car and NascarCar. You need to have for each class:
        //Property for each variable
        //Default constructor, and an overlaoded constructor that can be used to initialize the class' variables
    
    {
        //variables
        private string vin; 
        private string make;

        //properties
        public string VIN
        {
            set { vin = value; }
            get { return vin; }
        }

        public string Make
        {
            set { make = value; }
            get { return make; }
        }

        //default constructor
        public Car()
        {
            vin = "";
            make = "";
        }
        //overrided constructor to initialize values
        public Car(string vinnum, string makecar)
        {
            VIN = vinnum;
            Make = makecar;
        }

        public virtual void PrintInfo() //PrintInfo method to print VIN and Make
        {
            Console.WriteLine(VIN + Make);
        }
    }
}
