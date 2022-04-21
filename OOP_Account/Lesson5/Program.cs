using System;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Class TFraction");
			TFraction fr1 = new TFraction(2, 3);
			Console.WriteLine(fr1.ToString());

			TFraction fr2 = new TFraction(9, 34);
			TFraction fr3 = new TFraction(17, 18);
			Console.WriteLine($"Умножение: {fr2} * {fr3} = {fr2 * fr3}");

			fr2.set(7, 8);
			fr3.set(5, 6);
			Console.WriteLine($"Деление: {fr2} / {fr3} = {fr2 / fr3}");

			
			fr2.set(7, 24);
			fr3.set(11, 30);
			Console.WriteLine($"Сложение: {fr2} + {fr3} = {fr2 + fr3}");

			fr2.set(1, 2);
			fr3.set(4, 17);
			Console.WriteLine($"Вычитание: {fr2} - {fr3} = {fr2 - fr3}");

			TFraction fr4 = new TFraction(4, 17);
			if (fr4 == fr3)
				Console.WriteLine($"{fr4} == {fr3}");
			else Console.WriteLine($"{fr4} != {fr3}");

			Console.WriteLine($"{fr1} >=  {fr3} : {fr1 >= fr3}");
			Console.WriteLine($"{fr1} <  {fr3} : {fr1 < fr3}");

			fr2.set(45, 7);
			Console.WriteLine($"TFraction to Int:  {fr2} : {(int)fr2}");

			
			Console.WriteLine($"Float 3.65 to TFraction:  {(TFraction)3.65f}\n");
			Console.WriteLine("Class TFraction");
			TComplex comp1 = new TComplex(2, 3);
			Console.WriteLine(comp1.ToString());

			TComplex comp2 = new TComplex(9, 34);
			TComplex comp3 = new TComplex(17, 18);
			Console.WriteLine($"Умножение: {comp2} * {comp3} = {comp2 * comp3}");

			comp2.set(7, 8);
			comp3.set(5, 6);
			Console.WriteLine($"Деление: {comp2} / {comp3} = {comp2 / comp3}");

			comp2.set(7, 24);
			comp3.set(11, 30);
			Console.WriteLine($"Сложение: {comp2} + {comp3} = {comp2 + comp3}");

			comp2.set(1, 2);
			comp3.set(4, 17);
			Console.WriteLine($"Вычитание: {comp2} - {comp3} = {comp2 - comp3}");

			TComplex comp4 = new TComplex(4, 17);
			if (comp4 == comp3)
				Console.WriteLine($"{comp4} == {comp3}");
			else Console.WriteLine($"{comp4} != {comp3}");
		}
	}
}
