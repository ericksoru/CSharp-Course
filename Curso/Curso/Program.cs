using System;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int[] exampleTest1 = { 2, 6, 8, -10, 3 };
            ////Find(exampleTest1);
            //Console.WriteLine(DuplicateEncode("Success"));
            //string prueba = "cocacolao";
            //int test = prueba.Split("o").Length;
            //Console.WriteLine(test);
            ////foreach (var letra in trozo)
            ////{
            ////    Console.WriteLine(letra);
            ////}
            
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

        /*
         * convert a string to a new string where each character 
         * in the new string is "(" if that character appears only once in the original string, or ")" 
         * if that character appears more than once in the original string. 
         * Ignore capitalization when determining if a character is a duplicate.
         * Examples:

            "din"      =>  "((("
            "recede"   =>  "()()()"
            "Success"  =>  ")())())"
            "(( @"     =>  "))((" 
         */
        public static string DuplicateEncode(string word)
        {
            word=word.ToLower();
            //create a Dictionary to storage the times a char is repeated
            Dictionary<char, int> charsInString = new Dictionary<char, int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (!charsInString.ContainsKey(word[i]))                
                    charsInString.Add(word[i],1);                    
                
                if(charsInString[word[i]] ==1)
                {
                    for (int b = 0; b < word.Length; b++)
                    {
                        if (i != b && word[i] == word[b])//conditional to skip the add of current letter
                            charsInString[word[i]]++;         
                    }
                }
                
            }            
            string finalString = "";
            foreach (char valuestring in word)
            {
                if (charsInString[valuestring] > 1)
                    finalString += ")";
                else
                    finalString += "(";
            }
            return finalString;
        }
    }
}
