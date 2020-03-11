using System;
using FizzBuzzJazzFuzz;

namespace FizzBuzzJazzFuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Funksjon funksjon = new Funksjon();

            //I funksjonene under kan man putte inn de argumentene man ønsker
            
            //Vanlig FizzBuzz 
            funksjon.FizzBuzzJazzFuzz(3,5,"Fizz","Buzz", 100,false);
            
            //Modifisert FizzBuzz mattelek
            funksjon.FizzBuzzJazzFuzz(4,9,"Fuzz","Jazz", 100,true);

            
        }
    }
}