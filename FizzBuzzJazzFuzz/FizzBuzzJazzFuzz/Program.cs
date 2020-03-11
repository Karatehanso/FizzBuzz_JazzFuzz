using System;
using FizzBuzzJazzFuzz;

namespace FizzBuzzJazzFuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FizzBuzzMethod fizzBuzzMethod = new FizzBuzzMethod();

            //I funksjonene under kan man putte inn de argumentene man ønsker
            
            //Vanlig FizzBuzz 
            fizzBuzzMethod.FizzBuzz(3,5,"Fizz","Buzz", 100,false);
            
            //Modifisert FizzBuzz mattelek
            fizzBuzzMethod.FizzBuzz(4,9,"Fuzz","Jazz", 100,true);

            
        }
    }
}