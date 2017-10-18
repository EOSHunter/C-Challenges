using System;

namespace Challenge2
{
    public class Car
    {
        public int NumOfTires { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var car1 = new Car()
            {
                NumOfTires = 4,
                Year = 2010,
                Make = "BMW",
                Model = "328i"
            };

            var car2 = new Car()
            {
                NumOfTires = 4,
                Year = 2017,
                Make = "Porsche",
                Model = "718 Cayman S"
            };

            var car3 = new Car()
            {
                NumOfTires = 4,
                Year = 2018,
                Make = "Audi",
                Model = "R8"
            };


            Console.Write("The ");

            Console.Write(car1.Year);

            Console.Write(" " + car1.Make + " ");

            Console.Write(car1.Model);

            Console.Write(" has ");

            Console.Write(car1.NumOfTires);

            Console.Write(" tires.");

            Console.WriteLine(Environment.NewLine);


            Console.Write("The ");

            Console.Write(car2.Year);

            Console.Write(" " + car2.Make + " ");

            Console.Write(car2.Model);

            Console.Write(" has ");

            Console.Write(car2.NumOfTires);

            Console.Write(" tires.");

            Console.WriteLine(Environment.NewLine);


            Console.Write("The ");

            Console.Write(car3.Year);

            Console.Write(" " + car3.Make + " ");

            Console.Write(car3.Model);

            Console.Write(" has ");

            Console.Write(car3.NumOfTires);

            Console.Write(" tires.");

            Console.Write(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Would you like to create your own car? ( Y / N )");
            string userInput = Convert.ToString(Console.ReadLine()).ToUpper();

            if (userInput == "Y")
            {
                bool repeat = true;
                while (repeat)
                {

                    Console.WriteLine("Please enter your car's Make:");

                    string userMake = Convert.ToString(Console.ReadLine());


                    Console.WriteLine("Please enter your car's Model:");

                    string userModel = Convert.ToString(Console.ReadLine());


                    Console.WriteLine("Please enter your car's Year:");

                    int userYear = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("How many tires does your car have?");

                    int userTires = Convert.ToInt32(Console.ReadLine());

                    var userCar = new Car()
                    {
                        NumOfTires = userTires,
                        Make = char.ToUpper(userMake[0]) + userMake.Substring(1), //capitalize 1st char
                        Model = char.ToUpper(userModel[0]) + userModel.Substring(1), //capitalize 1st char
                        Year = userYear,
                    };

                    Console.Write(Environment.NewLine);


                    Console.Write("The ");

                    Console.Write(userCar.Year);

                    Console.Write(" " + userCar.Make + " ");

                    Console.Write(userCar.Model);

                    Console.Write(" has ");

                    Console.Write(userCar.NumOfTires);

                    Console.Write(" tires.");

                    Console.Write(Environment.NewLine);

                    Console.WriteLine("Want to build a car again?? ( Y / N )");
                    string continueAnswer = Convert.ToString(Console.ReadLine()).ToUpper();
                    if (continueAnswer == "Y")
                    {
                        repeat = true;
                    }
                    else
                    {
                        Console.WriteLine("Awesome, let's do it!");
                        repeat = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Alright, thanks for building with us!");
            }
        }
    }
}