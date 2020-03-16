using System;
using System.Collections.Generic;
using System.Linq;



    //Kan du se revurdere navngivning? I oppgave 2 spør vi etter en løsning som er fleksibel til å takle mer enn FizzBuzz. 
    //Hva er tanken bak å benytte Method som suffiks på en klasse?
    public class FizzBuzzMethod
    {

    //Disse kommentarene bør du implemetere som dokumentasjon av metoden med ///
    //https://docs.microsoft.com/en-us/dotnet/csharp/codedoc
    //divide_number_one = integer som er delelig med
    //replace_word_one = ord som vil erstatte integer
    //iterates = hvor mye man vil kjøre loope (1-100) / (100-1) i dette tilfelle
    //bool reversed:  true = da kjører man fra valgt iterator til 1, false = fra 1 til valgt iterator


    public void FizzBuzz(int divide_number_one, int divide_number_two, string replace_word_one, string replace_word_two, int iterates, bool reversed)

        {
            //Normal for loop
            if(!reversed)
                for(int i = 1; i <= iterates; i++)
                {
                    Statements(divide_number_one,divide_number_two,replace_word_one,replace_word_two,i);
                }

        //Reversert for loop
        //Tips. https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.reverse?view=netframework-4.8
        if (reversed)
                for(int i = iterates; i > 0; i--)
                {
                    Statements(divide_number_one,divide_number_two,replace_word_one,replace_word_two,i);
                }
        }

        //Denne funksjonen bestemmer hva som skjer når de ulike statements inntreffer
        //Klarer du å skille på eksekvering og utskrift? -Slik an man f.eks kan bruke løsningen på web.
        public void Statements(int divide_number_one, int divide_number_two, string replace_word_one, string replace_word_two, int i)
        {
            if (i % divide_number_one == 0 && i % divide_number_two == 0)
                    
                Console.WriteLine(replace_word_one + replace_word_two);
                
            //Blir det ikke litt vanskelig å lese koden med flere else if?
            //Hva skjer om du fjerner else og bare lar if stå igjen?
            else if (i % divide_number_one == 0)
            {
                Console.WriteLine(replace_word_one);
            }
            else if (i % divide_number_two == 0)
            {
                Console.WriteLine(replace_word_two);
            }
            else
            {
                Console.WriteLine(i);
            }
            
        }

    }



    
