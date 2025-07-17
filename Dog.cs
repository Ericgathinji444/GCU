// CST-150 Activity 5 – Part 1
// Author: Eric Gathinji
// Grand Canyon University – July 2025
// Description: Dog class holds attributes and business logic for circumference and weight conversion.

using System;

namespace BusinessLayer
{
    public class Dog
    {
        // Properties
        public string Name { get; set; }
        public double NeckRadius { get; set; } // inches
        public string SitOrLay { get; set; }
        public string Color { get; set; }
        public double WeightLbs { get; set; }

        /// <summary>
        /// Parameterized constructor to initialize dog attributes.
        /// </summary>
        public Dog(string name, double neckRadius, string sitOrLay, string color, double weightLbs)
        {
            Name = name;
            NeckRadius = neckRadius;
            SitOrLay = sitOrLay;
            Color = color;
            WeightLbs = weightLbs;
        }

        /// <summary>
        /// Calculates neck circumference in centimeters.
        /// </summary>
        public double CalCircumference()
        {
            return 2 * Math.PI * NeckRadius * 2.54; // Inches to cm
        }

        /// <summary>
        /// Converts weight from pounds to kilograms.
        /// </summary>
        public double CalWeight()
        {
            return WeightLbs * 0.453592; // Pounds to kg
        }
    }
}