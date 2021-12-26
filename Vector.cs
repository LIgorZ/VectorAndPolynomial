using System;
using System.Collections.Generic;
using System.Text;

namespace VectorAndPolynomial
{
    public class Vector
    {
        private double x;
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        private double y;
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        private double z;
        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        // Конструктор
        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //===============================================================
        // ---------------------ДЛИНА ВЕКТОРА----------------------------
        //===============================================================

        // Свойство
        private double length;
        public double Length
        {
            get
            {
                return Math.Round(Math.Sqrt(X * X + Y * Y + Z * Z), 2);
            }
            set
            {
                length = value;
            }
        }

        //===============================================================
        //------------------УГОЛ МЕЖДУ ДВУМЯ ВЕКТОРАМИ-------------------
        //===============================================================
        /* Здесь возвращается косинус угла 
         При желании можно найти градусы и радианы */
        public double Angle(Vector v)
        {
            double cos = Math.Round((X * v.X + Y * v.Y + Z * v.Z) / (this.Length * v.Length), 4);
            return Math.Acos(cos)*180/Math.PI;
        }

        //================================================================
        // Сложение векторов
        //================================================================
        public Vector Plus(Vector v)
        {
            double xx = X + v.X;
            double yy = Y + v.Y;
            double zz = Z + v.Z;
            return new Vector(xx, yy, zz);
        }
        // Переопределение операции +
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        //================================================================
        // Вычитание векторов
        //================================================================
        public Vector Minus(Vector v)
        {
            double xx = X - v.X;
            double yy = Y - v.Y;
            double zz = Z - v.Z;
            return new Vector(xx, yy, zz);
        }
        // Переопределение операции -
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }


        //================================================================
        // Умножение вектора на число
        //================================================================
        public Vector SubDigit(double digit)
        {
            return new Vector(X * digit, Y * digit, Z * digit);
        }
        // Переопределение операции *
        public static Vector operator *(double digit, Vector v1)
        {
            return new Vector(digit * v1.X, digit * v1.Y, digit * v1.Z);
        }

        //================================================================
        // Скалярное умножение векторов
        //================================================================
        public double SubScalar(Vector v)
        {
            return Math.Round(this.Length * v.Length * this.Angle(v), 2);
        }
        // Переопределение операции *
        public static double operator *(Vector v1, Vector v2)
        {
            return Math.Round(v1.Length * v2.Length * v1.Angle(v2), 2);
        }

        //================================================================
        // Векторное умножение векторов
        //================================================================
        public Vector SubVector(Vector v)
        {
            return new Vector((y * v.Z - z * v.Y), (-1) * (x * v.Z - z * v.X), (x * v.Y - y * v.X));
        }

        //================================================================
        // Переопределение метода ToString()
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", X, Y, Z);
        }

    }
}
