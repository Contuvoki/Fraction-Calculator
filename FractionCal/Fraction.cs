using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCal
{
    class Fraction
    {
        #region Properties

        private int Numerator;
        public int numerator
        {
            get { return Numerator; }
            set { Numerator = value; }
        }

        private int Denominator;
        public int denominator
        {
            get { return Denominator; }
            set { Denominator = value; }
        }

        #endregion

        #region Constructor

        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }

        #endregion

        #region Calculation

        public string Divisor(int a)
        {
            string b = "";
            for (int i = 1; i <= a; i++)
                if (a % i == 0)
                    b += i + "  ";
            return b;
        }

        public int GreatestCommonDivisor(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            return a + b;
        }

        public int CommonDenominator(Fraction x)
        {
            return (x.Denominator * Denominator) / GreatestCommonDivisor(Denominator, x.Denominator);
        }

        public void Reduce()
        {
            Numerator = Numerator / GreatestCommonDivisor(Numerator, Denominator);
            Denominator = Denominator / GreatestCommonDivisor(Numerator, Denominator);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction Result = new Fraction();
            Result.numerator = a.numerator * (a.CommonDenominator(b) / a.denominator) + b.numerator * (b.CommonDenominator(a) / b.denominator);
            Result.denominator = a.CommonDenominator(b);
            Result.Reduce();
            return Result;
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction Result = new Fraction();
            Result.numerator = a.numerator * (a.CommonDenominator(b) / a.denominator) - b.numerator * (b.CommonDenominator(a) / b.denominator);
            Result.denominator = a.CommonDenominator(b);
            Result.Reduce();
            return Result;
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction Result = new Fraction();
            Result.Numerator = a.Numerator * b.Numerator;
            Result.Denominator = a.Denominator * b.Denominator;
            Result.Reduce();
            return Result;
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction Result = new Fraction();
            Result.Numerator = b.Denominator * a.Numerator;
            Result.Denominator = b.Numerator * a.Denominator;
            Result.Reduce();
            return Result;
        }

        #endregion

        #region Compare

        public static bool operator ==(Fraction a, Fraction b)
        {
            if (((float)a.numerator / (float)a.denominator) == ((float)b.numerator / (float)b.denominator))
                return true;
            return false;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            if (((float)a.Numerator / (float)a.denominator) > ((float)b.Numerator / (float)b.denominator))
                return true;
            return false;
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            if (((float)a.Numerator / (float)a.denominator) < ((float)b.Numerator / (float)b.denominator))
                return true;
            return false;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            if (((float)a.numerator / (float)a.denominator) != ((float)b.numerator / (float)b.denominator))
                return true;
            return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Fraction b = obj as Fraction;
            if ((Object)b == null)
                return false;

            if (((float)Numerator / (float)denominator) == ((float)b.Numerator / (float)b.denominator))
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return Numerator.GetHashCode() ^ Denominator.GetHashCode();
        }

        #endregion
    }
}
