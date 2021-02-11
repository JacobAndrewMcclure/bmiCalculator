using System;

namespace obtainUserInfo
{
    class ObtainUserInfo
    {
        public int userHeight()
        {
            Console.Write(" Enter your height in inches: ");
            var heightString = Console.ReadLine();
            var height = Int32.Parse(heightString);

            return height;
        }
        public int userWeight()
        {
            Console.Write(" Enter your weight in pounds: ");
            var weightString = Console.ReadLine();
            var weight = Int32.Parse(weightString);

            return weight;
        }
    }
}