using System;

namespace bodyMassCalc
{
    class BodyMassCalc
    {
        public double bmiCalc(double weight, double height)
        {
            double bodyMassIndex = (weight * 703) / (height * height);
            return Math.Round(bodyMassIndex, 1);
        }
    }
}