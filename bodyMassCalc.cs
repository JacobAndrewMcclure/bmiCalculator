using System;

namespace bodyMassCalc
{
    class BodyMassCalc
    {
        public double bmiCalc(double weight, double height)
        {
            double x = (weight * 703) / (height * height);
            return Math.Round(x, 1);
        }
    }
}