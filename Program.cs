using System;
using bodyMassCalc;
using bodyMassRange;
using obtainUserInfo;
using userStatsDisplay;

namespace bmiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables
            double userHeight = 0;
            double userWeight = 0;
            double userBmi;
            string bodyMassRating;
            var userInputActivity = true;

            //Establish new class instances
            BodyMassCalc BodyMassCalc = new BodyMassCalc();
            BodyMassRange BodyMassRange = new BodyMassRange();
            ObtainUserInfo ObtainUserInfo = new ObtainUserInfo();
            UserStatsDisplay UserStatsDisplay = new UserStatsDisplay();
            
            while(userInputActivity == true)
            {
                try
                {
                //Ask user height
                userHeight = ObtainUserInfo.userHeight();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                //Ask user weight
                userWeight = ObtainUserInfo.userWeight();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                if (userHeight <= 0 || userWeight <= 0)
                {
                    userInputActivity = true;
                    Console.WriteLine("Invalid height or weight!");
                }
                else
                {
                    userInputActivity = false;
                }
            }
            //calculate BMI
            userBmi = BodyMassCalc.bmiCalc(userWeight, userHeight);
            //Determine BMI range good/obese/underweight etc....
            bodyMassRating = BodyMassRange.bodyMassRating(userBmi);
            //Display BMI and BMI range/rating
            UserStatsDisplay.displayUserBmi(userHeight,userWeight,userBmi,bodyMassRating);
        }
    }
}