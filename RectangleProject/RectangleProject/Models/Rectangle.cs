using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProject.Models
{
    public class Rectangle
    {
        //mezok
        private double sideA;
        private double sideB;

        //konstruktor peldanyositas
        public Rectangle(double sideA, double sideB)
        {
            //mindig this.
            this.sideA = sideA;
            this.sideB = sideB;

        }

        public double SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                sideA = value;
            }
        }
        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                sideB = value;
            }

        }

        public double Area
        {
            get
            {
                double area=sideA*sideB;
                return area;
            }

        }
        public double Perimeter
        {
            get
            {
                double perimeter = (2 * sideA) + (2 * sideB);
                return perimeter;
            }

        }

    }
}
