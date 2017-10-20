using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExam
{
    class Program:NascarCar
    {
        static void Main(string[] args)
        {
            List<Car> CarList = new List<Car>(); //define an array type of Car that will store 2 cars and 4 Nascar car objects inside the main function

            //you need to initialize the objects when you add them to the array. You can choose any values you want for that.

            CarList.Add(new Car("4G6899F2", "Chevrolet")); //creating and intializing new objects for car with values in CarList arary List
            CarList.Add(new Car("8J9267Y1", "Fiat"));

            CarList.Add(new NascarCar("9UUI6OV1", "Ford", "Team Grant Chirpus")); //creating and intializing new objects for Nascar Cars
            CarList.Add(new NascarCar("92OVJ8Z4", "Tesla", "Team Dr.K Rules"));
            CarList.Add(new NascarCar("6ISKD4P6", "Dodge", "Team Kim Krazy"));
            CarList.Add(new NascarCar("1MXC7PY9", "Chrysler", "Team Coding Captains"));

            foreach (Car Element in CarList)
            {
                Console.WriteLine(Element.ToString()); //converted PrintInfo() to ToString() in each class so there were no conversion issues with foreach loop
            }
        }
    }
}
