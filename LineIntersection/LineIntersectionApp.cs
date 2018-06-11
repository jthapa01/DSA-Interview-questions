using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineIntersection
{
    //Given two lines, Write a function to determine
    //whether or not they intersect
    class LineIntersectionApp
    {
        static void Main(string[] args)
        {
            Line a = new Line(2, 3);
            Line b = new Line(2, 4);
            bool result = a.Intercept(b);
            Console.WriteLine($"Line a and b intersect to each other?: {result}");
            Console.ReadKey();

        }
    }

    public class Line
    {
        private const double EPSILON = 0.00001;
        private double slope;
        private double yIntercept;

        public Line(int _slope, int _yIntercept)
        {
            this.slope = _slope;
            this.yIntercept = _yIntercept;
        }

        public bool Intercept(Line line)
        {
            //if two lines are equal they intersect
            if (this.Equals(line))
            {
                return true;
            }
            if (Math.Abs(slope - line.slope) > EPSILON)
            {
                return true;
            }
            return false;
        }

        public override bool Equals(Object o)
        {
            if(o == null||!(o is Line ))
            {
                return false;
            }
            Line line = (Line)o;
            return Math.Abs(this.slope - line.slope) < EPSILON &&
                Math.Abs(this.yIntercept - line.yIntercept) < EPSILON;
        }

        public override int GetHashCode()
        {
            var hashCode = 648983370;
            hashCode = hashCode * -1521134295 + slope.GetHashCode();
            hashCode = hashCode * -1521134295 + yIntercept.GetHashCode();
            return hashCode;
        }
    }
}
