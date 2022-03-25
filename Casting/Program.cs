using Casting.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius celcius = new Celsius(10);
            Kelvin kelvin = celcius;
            Console.WriteLine((kelvin.Degree) + "K");
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




}
