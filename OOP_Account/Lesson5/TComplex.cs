using System;


namespace Lesson5
{
    internal class TComplex
    {
        //вещественная часть, мнимая часть
        private double _real, _imag;

        public TComplex() { set(0.0, 0.0); }
        public TComplex(double r, double i) { set(r, i); }

		public double Real { get { return _real; } }
		public double Imag { get { return _imag; } }

		/// <summary>
		/// Инициализация комплексного числа
		/// </summary>
		/// <param name="real">Вещественная часть</param>
		/// <param name="imag">Мнимая часть</param>
		public void set(double real, double imag)
        {
            _real = real;
            _imag = imag;
        }

		public static TComplex operator +(TComplex comp1, TComplex comp2) 
		{
			TComplex comp = new TComplex();
			comp.set(comp1.Real + comp2.Real, comp1.Imag + comp2.Imag);
			return comp;

		}

		public static TComplex operator *(TComplex comp1, TComplex comp2)
		{
			TComplex comp = new TComplex();
			double r = (comp1.Real * comp2.Real) - (comp1.Imag * comp2.Imag);
			double i = (comp1.Real * comp2.Imag) + (comp1.Imag * comp2.Real);
			comp.set(r, i);
			return comp;

		}
		public static TComplex operator -(TComplex comp1, TComplex comp2)
		{
			TComplex comp = new TComplex();
			comp.set(comp1.Real - comp2.Real, comp1.Imag - comp2.Imag);
			return comp;

		}
		public static TComplex operator /(TComplex comp1, TComplex comp2)
		{
			TComplex comp = new TComplex();
			if ((comp2.Real == 0.0) && (comp2.Imag == 0.0))
			{
				comp.set(0, 0);
				return comp;
			}
			double denom = (comp2.Real * comp2.Real) + (comp2.Imag * comp2.Imag);
			double r = ((comp1.Real * comp2.Real) + (comp1.Imag * comp2.Imag)) / denom;
			double i = ((comp1.Imag * comp2.Real) - (comp1.Real * comp2.Imag)) / denom;
			comp.set(r, i);
			return comp;
		}

		public static bool operator == (TComplex comp1, TComplex comp2) 
		{
			if (comp1.Real == comp2.Real && comp1.Imag == comp2.Imag) 
			{
				return true;
			}
			else return false;
		}

		public static bool operator !=(TComplex comp1, TComplex comp2)
		{
			if (comp1.Real == comp2.Real && comp1.Imag == comp2.Imag)
			{
				return false;
			}
			else return true;
		}

		public override bool Equals(Object obj)
		{
			return ((obj is TComplex) && (this == (TComplex)obj));
		}

		public override int GetHashCode()
		{

			return (Real.GetHashCode() ^ Imag.GetHashCode());
		}
		public override string ToString()
		{
			return Real + " + i*" + Imag;
		}
	}

}

