using System;

namespace AreaLibraryTest
{
    public class MathLibrary
    {
        public static double ComputeArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double ComputeArea(double FirstSide, double SecondSide, double ThirdSide)
        {
            if (Math.Pow(FirstSide, 2) == Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2))
            {
                return SecondSide * ThirdSide / 2;
            }
            else
            {
                if (Math.Pow(SecondSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2))
                {
                    return FirstSide * ThirdSide / 2;
                }
                else
                {
                    if (Math.Pow(ThirdSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2))
                    {
                        return FirstSide * SecondSide / 2;
                    }
                    else
                    {
                        double HalfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
                        return Math.Sqrt((HalfPerimeter * (HalfPerimeter - FirstSide) * (HalfPerimeter - SecondSide) * (HalfPerimeter - ThirdSide)));
                    }
                }
            }
        }
    }
}
