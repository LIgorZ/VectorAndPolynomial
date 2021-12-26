using System;

namespace VectorAndPolynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NET.C#.05 Инакапсуляция данных и методов");
            Console.WriteLine("Задание 1.Векторы");
            Vector a = new Vector(0, 1, 1);
            Vector b = new Vector(0, 1, 3);

            Console.WriteLine("Дано: вектор а{0} и вектор b{1}", a.ToString(), b.ToString());

            // Длина векторов
            // Свойства
            Console.WriteLine("Длина векторв a: {0}", a.Length);
            Console.WriteLine("Длина векторв b: {0}", b.Length);
            // Методы
            //Console.WriteLine("Длина векторв a: {0}", a.Length());
            //Console.WriteLine("Длина векторв b: {0}", b.Length());

            // Угол между векторам (cos)
            Console.WriteLine("Угол между вектором a и b, градусы: {0}", a.Angle(b));

            // Сложение векторов
            Console.WriteLine("a{0} + b{1} = c{2}", a.ToString(), b.ToString(), a.Plus(b));
            Console.WriteLine("a{0} + b{1} = c{2}", a.ToString(), b.ToString(), a + b);

            // Умножение вектора на число
            Console.WriteLine("{0} * a{1} = c{2}", 2, a.ToString(), a.SubDigit(2));
            Console.WriteLine("{0} * a{1} = c{2}", 2, a.ToString(), 2 * a);

            // Скалярное умножение
            Console.WriteLine("a{0} * b{1} = {2}", a.ToString(), b.ToString(), a.SubScalar(b));
            Console.WriteLine("a{0} * b{1} = {2}", a.ToString(), b.ToString(), a * b);

           // Console.ReadKey();

            Console.WriteLine("Задание 2.Многочлены");
            Polynomial p1 = new Polynomial(1, 15);
            Polynomial p2 = new Polynomial(3, 12, 24, 35);
            Console.WriteLine("{0} + {1} = {2}", p1, p2, p1 + p2);
            Console.WriteLine("{0} - {1} = {2}", p1, p2, p1 - p2);
            Console.WriteLine("{0} * {1} = {2}", p1, p2, p1 * p2);
            Console.WriteLine("{0} равно {1} = {2}", p1, p2, p1 == p2);
            Console.WriteLine("{0} и {1}: х = {2}", p1, p2, (p1 * p2).Calculate(1.2d));
            Console.ReadKey();

        }
    }
}
