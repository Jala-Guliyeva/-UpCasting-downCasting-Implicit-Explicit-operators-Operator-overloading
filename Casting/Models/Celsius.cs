using System;
using System.Collections.Generic;
using System.Text;

namespace Casting.Models
{
    internal class Celsius
    {
        public int Degree { get; set; }
        public Celsius(int celsius)
        {
            Degree = celsius;
        }
        public static implicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.Degree + 273);
        }

    }
}
