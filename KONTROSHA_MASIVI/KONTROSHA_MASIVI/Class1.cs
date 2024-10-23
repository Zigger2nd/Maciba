using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KONTROSHA_MASIVI
{
    internal class Rectangle
    {
        //1,2 uzd
        private double a, b;
        public Rectangle(double aa, double bb) { a=aa; b = bb; }
        public bool IsRectangle()
        {
            return a > 0 && b > 0;
        }
        public bool IsSquare()
        {
            return IsRectangle() && a==b;
        }
        public double S()
        {
            return IsRectangle() ? a * b : 0;
        }
        public double P()
        {
            return IsRectangle() ? 2 * (a + b) : 0;
        }
        public double D()
        {
            return IsRectangle() ? Math.Round(Math.Sqrt(a * a + b * b),2) : 0;
        }
        public double R()
        {
            return IsRectangle() ? Math.Min(a, b) / 2 : 0;
        }
        //3.uzd
        public static Rectangle operator ++(Rectangle t)
        {
            t.a += 1;
            t.b += 1;
            return t;
        }
        public static Rectangle operator --(Rectangle t)
        {
            if (t.a - 1 <= 0 || t.b - 1 <= 0)
            {
                throw new Exception("Kāda no taisnstūra malām kļūst nepareiza (<=0) pēc samazināšanas.");
            }
            t.a -= 1;
            t.b -= 1;
            return t;
        }
        //4.uzd
        public static bool operator >(Rectangle t1, Rectangle t2)
        {
            return t1.S() > t2.S();
        }
        public static bool operator <(Rectangle t1, Rectangle t2)
        {
            return t1.S() < t2.S();
        }

        public static bool operator ==(Rectangle t1, Rectangle t2)
        {
            return t1.a == t2.a && t1.b == t2.b;
        }

        public static bool operator !=(Rectangle t1, Rectangle t2)
        {
            return !(t1 == t2);
        }
        //5.uzd
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public override string ToString()
        {
            return IsRectangle() ? $"Taisnstūris: a = {a}, b = {b}" : "Error: Tas nav taisnstūris";
        }
    }
}
