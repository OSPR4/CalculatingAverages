/*
Class:       ISTA 220 Programming Fundamentals in C#
Student:     Osee Pierre
Instructor:  Christine Lee
Date:        07/18/20
Description: Create a console application that:
             1: Accept ten numbers between 0 and 100, and report their sum
             2: Average ten scores between 0 and 100, and report their average
             3: Average a specific number of scores between 0 and 100, and report their average and letter grade
             4: Average a non-specific number of scores between 0 and 100, and report their average and letter grade
Revised:     
Revised by:  
Revision:   
*/

using System;

namespace CalculatingAverages
{

    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                char response;
                int selection;

                Console.WriteLine("1: Sum of numbers\n2: Average ten scores\n3: Average a specific number of scores\n" +
                    "4: Average a non-specific number of scores\n");
                Console.Write("Enter a corresponding number from the options above: ");

                selection = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (selection)
                {
                    case 1:
                        //Sum of numbers
                        SumOfNums();
                        break;
                    case 2:
                        //Average ten scores
                        AvgTenScores();
                        break;
                    case 3:
                        //Average a specific number of scores
                        AvgNumOfScores_Fixed();
                        break;
                    case 4:
                        //Average a non-specific number of scores
                        AvgNumOfScores_Gen();
                        break;
                }
                Console.Write("\nWould you like to make another selection? Y or N: ");
                response = char.Parse(Console.ReadLine());

                if (response == 'n' || response == 'N')
                    break;

                Console.WriteLine();

            }

        }

        static void SumOfNums()
        {
            float total = 0;
            Console.WriteLine("Enter 10 digits between 0 and 100:");

            for (int i = 0; i < 10; i++)
            {
                float input = float.Parse(Console.ReadLine());
                while (input < 0 || input > 100)
                {
                    Console.WriteLine("Digit must be between 0 and 100");
                    Console.WriteLine("Enter the test scores: ");
                    input = float.Parse(Console.ReadLine());
                }
                total += input;
            }

            Console.WriteLine($"\nThe sum for the 10 digits entered is : {total}");
        }

        static void AvgTenScores()
        {
            float total = 0;
            float input = 0;
            Console.WriteLine("Enter 10 test scores between 0 and 100");

            for (int i = 0; i < 10; i++)
            {
                input = float.Parse(Console.ReadLine());
                while (input < 0 || input > 100)
                {
                    Console.WriteLine("Digit must be between 0 and 100");
                    Console.WriteLine("Enter the test scores: ");
                    input = float.Parse(Console.ReadLine());
                }
                total += input;
            }

            float average = total / 10;
            if (average >= 90 && average <= 100)
                Console.WriteLine($"\nYour average for the 10 scores entered is : {average}\nLetter Grade: A");
            if (average >= 80 && average <= 89)
                Console.WriteLine($"\nYour average for the 10 scores entered is : {average}\nLetter Grade: B");
            if (average >= 70 && average <= 79)
                Console.WriteLine($"\nYour average for the 10 scores entered is : {average}\nLetter Grade: C");
            if (average >= 60 && average <= 69)
                Console.WriteLine($"\nYour average for the 10 scores entered is : {average}\nLetter Grade: D");
            if (average >= 0 && average <= 59)
                Console.WriteLine($"\nYour average for the 10 scores entered is : {average}\nLetter Grade: F");


        }

        static void AvgNumOfScores_Fixed()
        {
            float average = 0;
            float input = 0;
            float total = 0;
            Console.Write("Enter the number of test scores: ");
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the test scores: ");

            for (int i = 0; i < limit; i++)
            {
                input = float.Parse(Console.ReadLine());
                while (input < 0 || input > 100)
                {
                    Console.WriteLine("Digit must be between 0 and 100");
                    Console.WriteLine("Enter test score: ");
                    input = float.Parse(Console.ReadLine());
                }
                total += input;
            }

            average = total / limit;
            if (average >= 90 && average <= 100)
                Console.WriteLine($"\nYour average for the {limit} score(s) entered is: {average}\nLetter Grade: A");
            if (average >= 80 && average <= 89)
                Console.WriteLine($"\nYour average for the {limit} score(s) entered is: {average}\nLetter Grade: B");
            if (average >= 70 && average <= 79)
                Console.WriteLine($"\nYour average for the {limit} score(s) entered is: {average}\nLetter Grade: C");
            if (average >= 60 && average <= 69)
                Console.WriteLine($"\nYour average for the {limit} score(s) entered is: {average}\nLetter Grade: D");
            if (average >= 0 && average <= 59)
                Console.WriteLine($"\nYour average for the {limit} score(s) entered is: {average}\nLetter Grade: F");

        }

        static void AvgNumOfScores_Gen()
        {

            int limit = 0;
            float average = 0;
            float input = 0;
            float total = 0;
            char response;



            while (true)
            {
                Console.Write("Enter test score: ");
                input = float.Parse(Console.ReadLine());
                while (input < 0 || input > 100)
                {
                    Console.WriteLine("Digit must be between 0 and 100");
                    Console.Write("Enter the test scores: ");
                    input = float.Parse(Console.ReadLine());
                }
                total += input;
                limit++;

                Console.Write("Would you like to enter another score? Y or N: ");

                response = char.Parse(Console.ReadLine());
                if (response == 'n' || response == 'N')
                    break;



            }

            average = total / limit;
            if (average >= 90 && average <= 100)
                Console.WriteLine($"\nYour average for the {limit} score(s) entered is: {average}\nLetter Grade: A");
            if (average >= 80 && average <= 89)
                Console.WriteLine($"\nYour average for the {limit} score(s) entered is: {average}\nLetter Grade: B");
            if (average >= 70 && average <= 79)
                Console.WriteLine($"\nYour average for the {limit} score(s) entered is: {average}\nLetter Grade: C");
            if (average >= 60 && average <= 69)
                Console.WriteLine($"\nYour average for the {limit} score(s) entered is: {average}\nLetter Grade: D");
            if (average >= 0 && average <= 59)
                Console.WriteLine($"\nYour average for the {limit} score(s) entered is: {average}\nLetter Grade: F");
        }
    }
}
