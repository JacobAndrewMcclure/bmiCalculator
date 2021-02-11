using System;

namespace userStatsDisplay
{
    public class UserStatsDisplay
    {
        public string displayUserBmi(double height, double weight, double bmi, string rating)
        {
            Console.WriteLine("");
            Console.WriteLine($"      Your height: {height}"); 
            Console.WriteLine($"      Your weight: {weight}");
            Console.WriteLine($"         Your BMI: {bmi}");
            Console.WriteLine($"  Your BMI rating: {rating}");

            return null;
        }
    }
}