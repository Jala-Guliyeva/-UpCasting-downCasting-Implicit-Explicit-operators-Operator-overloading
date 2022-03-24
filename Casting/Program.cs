using System;
using System.ComponentModel.DataAnnotations;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius(2);
            //Kelvin kelvin = celsius;
            Console.WriteLine(celsius.Degree);
        }
    }
    enum Currency
    {

        [Display(Name = " Dollar $")]
        USD,
        [Display(Name = "Yevro $")]
        EUR,
        [Display(Name = "Turk lirasi ¥")]
        TRY
    }
    public void ExChange(Enum pul, double azn)
    {
        
    }


    class Kelvin
    {
        public int Degree { get; set; }
        public Kelvin(int degree)
        {
            Degree = degree;    
        }

        //public static implicit operator Kelvin(Celsius v)
        //{
        //    throw new NotImplementedException();
        //}
    }
    class Celsius
    {
        public int Degree { get; set; }
        public Celsius(int degree)
        {
            Degree = degree;
        }
        public static implicit operator Celsius(Kelvin k)
        {
            return new Celsius(k.Degree/273);   
        }

    }
}
