using System;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] exampleTest1 = { 2, 6, 8, -10, 3 };
            Find(exampleTest1);

        }
        /*
         * [2, 4, 0, 100, 4, 11, 2602, 36]
         * Should return: 11 (the only odd number)
         * 
         * [160, 3, 1719, 19, 11, 13, -21]
         * Should return: 160 (the only even number)
         */
        public static int Find(int[] integers)
        {
            var countOddNumber = 0;
            var countEvenNumber = 0;
            var oddNumber = 0;
            var evenNumber = 0;
            

            foreach (var number in integers)
            {
                if (number % 2 == 0)
                {                    
                    countEvenNumber++;
                    evenNumber = number;
                }
                else
                {                    
                    countOddNumber++;
                    oddNumber = number;
                }

                if (countEvenNumber > 1 && countOddNumber != 0)
                {
                    return oddNumber;
                }
                if (countOddNumber > 1 && countEvenNumber !=0 )
                {
                    return evenNumber;
                }
                
            }
            return -1;
        }
        /*
         * MakeComplement("ATTGC") => "TAACG"
         * MakeComplement("GTAT") => "CATA"
         */
        public static string MakeComplement(string dna)
        {
            var newDna = "";
            var constraintsG1 = new char[2] {'a','g', };
            var constraintsG2 = new char[2] { 't','c' };             

            for (int i = 0; i <= dna.Length; i++)
            {
                for (int constr = 0; constr < 2; constr++)
                {
                    if (dna[i] == constraintsG1[constr])
                    {
                        newDna += constraintsG2[constr].ToString();
                    }
                    if (dna[i] == constraintsG2[constr])
                    {
                        newDna += constraintsG1[constr].ToString();
                    }
                }
            }
            return newDna;
             
        }
    }
}
