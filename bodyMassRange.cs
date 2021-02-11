namespace bodyMassRange
{
    class BodyMassRange
    {
        public string bodyMassRating(double bodyIndex)
        {
            if (bodyIndex < 0)
            {
                return "Invalid BMI";
            }
            else if (bodyIndex < 18.5)
            {
                return "Underweight";
            }
            else if (bodyIndex < 24.9)
            {
                return "Normal weight";
            }
            else if (bodyIndex <29.9)
            {
                return "Overweight";
            }
            else if (bodyIndex > 30)
            {
                return "Obesity";
            }
            else
            {
                return "Invalid Operation";
            }
        }
    }
}