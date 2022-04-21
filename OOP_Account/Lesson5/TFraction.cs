
using System;

namespace Lesson5
{
    internal class TFraction
    {
        //числитель и знаменатель
        private int _num, _den;

        public TFraction() { set(0, 1); }

        public TFraction(int num, int den)
        { 
           set(num, den);
        }

        public int Numerator { get { return _num; } }
        public int Denominator { get { return _den; } }

        /// <summary>
        /// Сокращение дроби
        /// </summary>
        private void Normalize()
        {
            if (_den == 0 || _num == 0)
            {
                _num = 0;
                _den = 1;
            }
            //отрицательный знак в числитель
            if (_den < 0)
            {
                _num *= -1;
                _den *= -1;
            }
            int n = GCF(_num, _den);
            _num /= n;
            _den /= n;

        }

        /// <summary>
        /// Наибольший общий делитель
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        /// <returns>НОД</returns>
        private int GCF(int a, int b)
        {
            if (b == 0)
            {
                return Math.Abs(a);
            }
            else
                return GCF(b, a % b);
        }

        /// <summary>
        /// Наименьшее общее кратное
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        /// <returns>НОК</returns>
        private int LCM(int a, int b)
        {
            int n = GCF(a, b);
            return a / n * b;
        }


        /// <summary>
        /// Инициализирует дробь
        /// </summary>
        /// <param name="num">Числитель</param>
        /// <param name="den">Знаменатель</param>
        public void set(int num, int den)
        {
            _num = num;
            _den = den;
            Normalize();
        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        /// <param name="other">Дробь</param>
        /// <returns>Сумма дробей</returns>
        private TFraction Add(TFraction other)
        {
            TFraction fract = new TFraction();
            int lcm = LCM(Denominator, other.Denominator);
            int quot1 = lcm / Denominator;
            int quot2 = lcm / other.Denominator;
            fract.set(Numerator * quot1 + other.Numerator * quot2, lcm);
            return fract;
        }

        /// <summary>
        /// Перегрузка +
        /// </summary>
        /// <param name="fract1">Дробь</param>
        /// <param name="fract2">Дробь</param>
        /// <returns>Сумма дробей</returns>
        public static TFraction operator + (TFraction fract1, TFraction fract2)
        {
            return fract1.Add(fract2);
        }

        /// <summary>
        /// Перегрузка ++
        /// </summary>
        /// <param name="fact1">Дробь</param>
        /// <returns>Дробь, увеличенная на 1</returns>
        public static TFraction operator ++ (TFraction fact1)
        {
            return fact1.Add(new TFraction(1, 1));
        }

        /// <summary>
        /// Умножение дробей
        /// </summary>
        /// <param name="other">Дробь</param>
        /// <returns>Произведение дробей</returns>
        private TFraction Mult(TFraction other)
        {
            TFraction fract = new TFraction();
            fract.set(Numerator * other.Numerator, Denominator * other.Denominator);
            return fract;
        }

        /// <summary>
        /// Перегрузка *
        /// </summary>
        /// <param name="fract1">Дробь</param>
        /// <param name="fract2">Дробь</param>
        /// <returns>Произведение дробей</returns>
        public static TFraction operator *(TFraction fract1, TFraction fract2)
        {
            return fract1.Mult(fract2);
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        /// <param name="other">Дробь</param>
        /// <returns>Разность дробей</returns>
        private TFraction Minus(TFraction other)
        {
            TFraction fract = new TFraction();
            fract.set(Numerator * other.Denominator - other.Numerator * Denominator, Denominator * other.Denominator);
            return fract;
        }

        /// <summary>
        /// Перегрузка -
        /// </summary>
        /// <param name="fract1">Дробь</param>
        /// <param name="fract2">Дробь</param>
        /// <returns>Разность дробей</returns>
        public static TFraction operator -(TFraction fract1, TFraction fract2)
        {
            return fract1.Minus(fract2);
        }

        /// <summary>
        /// Перегрузка --
        /// </summary>
        /// <param name="fract1">Дробь</param>
        /// <returns>Дробь, уменьшенная на 1</returns>
        public static TFraction operator --(TFraction fract1)
        {
            return fract1.Minus(new TFraction(1, 1));
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        /// <param name="other">Дробь</param>
        /// <returns>Частное двух дробей</returns>
        private TFraction Div(TFraction other)
        {
            TFraction fract = new TFraction();
            fract.set(Numerator * other.Denominator, Denominator * other.Numerator);
            return fract;
        }

        /// <summary>
        /// Перегрузка /
        /// </summary>
        /// <param name="fract1">Делимое</param>
        /// <param name="fract2">Делитель</param>
        /// <returns>Частное двух дробей</returns>
        public static TFraction operator /(TFraction fract1, TFraction fract2)
        {
            return fract1.Div(fract2);
        }

        /// <summary>
        /// Перегрузка %
        /// </summary>
        /// <param name="fract1">Делимое</param>
        /// <param name="fract2">Делитель</param>
        /// <returns>Частное двух дробей</returns>
        public static TFraction operator %(TFraction fract1, TFraction fract2)
        {
            return fract1.Div(fract2);
        }


        public static bool operator ==(TFraction fract1, TFraction fract2)
        {
            return ((fract1.Numerator == fract2.Numerator) && (fract1.Denominator == fract2.Denominator));
        }


        public static bool operator !=(TFraction fract1, TFraction fract2)
        {
            return (!(fract1 == fract2));
        }


        public override bool Equals(Object obj)
        {
            return ((obj is TFraction) && (this == (TFraction)obj));
        }


        public override int GetHashCode()
        {
            return (Numerator.GetHashCode() ^ Denominator.GetHashCode());
        }

        public static bool operator >(TFraction fract1, TFraction fract2)
        {
            return fract1.Numerator * fract2.Denominator > fract2.Numerator * fract1.Denominator;
        }

        public static bool operator <(TFraction fract1, TFraction fract2)
        {
            return fract1.Numerator * fract2.Denominator < fract2.Numerator * fract1.Denominator;
        }

        public static bool operator >=(TFraction fract1, TFraction fract2)
        {
            return fract1.Numerator * fract2.Denominator >= fract2.Numerator * fract1.Denominator;
        }

        public static bool operator <=(TFraction fract1, TFraction fract2)
        {
            return fract1.Numerator * fract2.Denominator <= fract2.Numerator * fract1.Denominator;
        }

        public static explicit operator TFraction(float _float)
        {
            string[] digits = _float.ToString().Replace(",", ".").Split(".");
            int power = digits.Length > 1 ? digits[1].Length : 0;
            TFraction fract = new TFraction();
            fract.set((int)(_float * Math.Pow(10, power)), (int)Math.Pow(10, power));
            return fract;
        }
        public static implicit operator float(TFraction fract)
        {
            return (float)fract.Numerator / fract.Denominator;

        }

        public static explicit operator TFraction(int _int)
        {
            TFraction fract = new TFraction();
            fract.set(_int, 1);
            return fract;
        }
        public static implicit operator int(TFraction fract)
        {
            return fract.Numerator / fract.Denominator;

        }
    }

}
