using System;
using System.Collections.Generic;
using System.Linq;



    public class Funksjon
    {
        
        //divide_number_one = integer som er delelig med
        //replace_word_one = ord som vil erstatte integer
        //iterates = hvor mye man vil kjøre loope (1-100) / (100-1) i dette tilfelle
        //bool reversed:  true = da kjører man fra valgt iterator til 1, false = fra 1 til valgt iterator

        
        public void FizzBuzzJazzFuzz(int divide_number_one, int divide_number_two, string replace_word_one, string replace_word_two, int iterates, bool reversed)

        {
            //Normal for loop
            if(!reversed)
                for(int i = 1; i <= iterates; i++)
                {
                    Statements(divide_number_one,divide_number_two,replace_word_one,replace_word_two,i);
                }
            
            //Reversert for loop
            if(reversed)
                for(int i = iterates; i > 0; i--)
                {
                    Statements(divide_number_one,divide_number_two,replace_word_one,replace_word_two,i);
                }
        }

        //Denne funksjonen bestemmer hva som skjer når de ulike statements inntreffer
        public void Statements(int divide_number_one, int divide_number_two, string replace_word_one, string replace_word_two, int i)
        {
            if (i % divide_number_one == 0 && i % divide_number_two == 0)
                    
                Console.WriteLine(replace_word_one + replace_word_two);
                
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



    
