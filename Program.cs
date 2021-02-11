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
            double userHeight;
            double userWeight;
            double userBmi;
            string bodyMassRating;

            //Establish new class instances
            BodyMassCalc BodyMassCalc = new BodyMassCalc();
            BodyMassRange BodyMassRange = new BodyMassRange();
            ObtainUserInfo ObtainUserInfo = new ObtainUserInfo();
            UserStatsDisplay UserStatsDisplay = new UserStatsDisplay();
            
            //Ask user height
            userHeight = ObtainUserInfo.userHeight();
            //Ask user weight
            userWeight = ObtainUserInfo.userWeight();
            //calculate BMI
            userBmi = BodyMassCalc.bmiCalc(userWeight, userHeight);
            //Determine BMI range good/obese/underweight etc....
            bodyMassRating = BodyMassRange.bodyMassRating(userBmi);
            //Display BMI and BMI range/rating
            UserStatsDisplay.displayUserBmi(userHeight,userWeight,userBmi,bodyMassRating);
        }
    }
}