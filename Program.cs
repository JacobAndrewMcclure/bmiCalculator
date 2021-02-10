using System;
using bodyMassCalc;

namespace bmiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double userHeight;
            double userWeight;
            double userBmi;
            string heightString;
            string weightString;

            BodyMassCalc BodyMassCalc = new BodyMassCalc();
            
            //ask user height
            Console.WriteLine("Enter your height in inches: ");
            heightString = Console.ReadLine();
            userHeight = Int32.Parse(heightString);
            //ask user weight
            Console.WriteLine("Enter your weight in pounds: ");
            weightString = Console.ReadLine();
            userWeight = Int32.Parse(weightString);
            //calculate BMI
            userBmi = BodyMassCalc.bmiCalc(userWeight, userHeight);

            //Determine BMI range good/obese/underweight etc....

            //Display BMI and BMI range/rating
            Console.WriteLine($"height = {userHeight} weight = {userWeight} BMI = {userBmi}");
        }
    }
}