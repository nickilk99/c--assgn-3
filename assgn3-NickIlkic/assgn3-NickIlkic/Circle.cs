using System;
using System.Collections.Generic;
using System.Text;

namespace assgn3_NickIlkic
{




    class Circle
    {
        public double radius { set; get; }
        public double area { get; set; }

        public double circumference { get; set; }


        public Circle(double r)
        {
            radius = r;
            CircleCalc calcArea = CircleArea;
            CircleCalc calcCirc = CircleCircumference;

            area = calcArea(r);
            circumference = calcCirc(r);
        }
        

        public delegate double CircleCalc(double radius);

        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CircleCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }





    }
}
