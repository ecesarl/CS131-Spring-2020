﻿using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5]; // creating a new array of type integer named 'numbers'
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;

            //// print out the whole array
            ////for (int i = 0; i < numbers.Length; i++) {
            ////    Console.Write(numbers[i] + " ");
            ////}

            //foreach (int number in numbers) {
            //    Console.Write(number + " ");
            //}

            string[] Sentence = new string[] {
                "This",
                "is",
                "a",
                "string"
            };

            foreach (string word in Sentence) {
                Console.Write(word + " ");
            }
        }
    }
}

