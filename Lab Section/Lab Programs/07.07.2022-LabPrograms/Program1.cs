using System;
using System.Timers;
using System.Threading;
using Timer = System.Timers.Timer;
namespace McqTest
{
    //Console Application For Mcq Test
    class Test
    {
        //Declaring Recquired Variables
        string candidateName;
        int candidateID;
        string[,] questions = new string[10, 5];
        string[] answers = new string[10];
        int mark = 0;
        //method for Get Candidate Details
        void GetCandidateDetails()
        {
            Console.WriteLine("Enter CandidateDetails");
            Console.WriteLine();
            Console.Write("Enter Candidate Name : ");
            candidateName = Console.ReadLine();
            Console.Write("Enter Candidate ID : ");
            candidateID = int.Parse(Console.ReadLine());
        }
        //method for Initilizing Questions
        void InitQuestions()
        {
            questions[0, 0] = "What is a StringBuilder ? ";
            questions[0, 1] = "a. datatype ";
            questions[0, 2] = "b. class";
            questions[0, 3] = "c. object";
            questions[0, 4] = "d. variable";
            questions[1, 0] = "What is string ?";
            questions[1, 1] = "a. datatype";
            questions[1, 2] = "b. class";
            questions[1, 3] = "c. object";
            questions[1, 4] = "d. variable";
            questions[2, 0] = "Choose the Statement Which is true";
            questions[2, 1] = "a. String is not depend upon values";
            questions[2, 2] = "b. String is mutable";
            questions[2, 3] = "c. stringBuilder is immutable";
            questions[2, 4] = "d. String Builder is used when value is keepon changes";
            questions[3, 0] = " Correct Syntax for declaring StringBuilder ";
            questions[3, 1] = "a. StringBuilder name = new StringBuilder()";
            questions[3, 2] = "b. stringbuilder name = new stringbuilder(value)";
            questions[3, 3] = "c. StringBuilder name = new StringBuilder(value)";
            questions[3, 4] = "d. stringbuilder name = new stringbuilder()";
            questions[4, 0] = " Correct Syntax for initilizing StringBuilder ";
            questions[4, 1] = "a. StringBuilder name = new StringBuilder()";
            questions[4, 2] = "b. stringbuilder name = new stringbuilder(value)";
            questions[4, 3] = "c. StringBuilder name = new StringBuilder(value)";
            questions[4, 4] = "d. stringbuilder name = new stringbuilder()";
            questions[5, 0] = " Equals() return ";
            questions[5, 1] = "a. integer";
            questions[5, 2] = "b. boolean";
            questions[5, 3] = "c. float";
            questions[5, 4] = "d. string";
            questions[6, 0] = " CompareTo() return ";
            questions[6, 1] = "a. integer";
            questions[6, 2] = "b. boolean";
            questions[6, 3] = "c. float";
            questions[6, 4] = "d. string";
            questions[7, 0] = "Total number of parameters in Trim() method";
            questions[7, 1] = "a. 1";
            questions[7, 2] = "b. 2";
            questions[7, 3] = "c. 3";
            questions[7, 4] = "d. 4";
            questions[8, 0] = "To change one character to another characte _______ method is used";
            questions[8, 1] = "a. Length()";
            questions[8, 2] = "b. ToString()";
            questions[8, 3] = "c. Convert()";
            questions[8, 4] = "d. Replace()";
            questions[9, 0] = "To add One string to another string _______ method is used ";
            questions[9, 1] = "a. Concade()";
            questions[9, 2] = "b. Append()";
            questions[9, 3] = "c. +";
            questions[9, 4] = "d. Add()";
        }
        //inizilizing correct Answers
        string[] crtAnswers = { "b", "a", "d", "a", "c", "b", "a", "b", "d", "b" };
        //method for Display questions and get answers
        void ShowQuestions()
        {
            Console.WriteLine();
            Console.WriteLine("Your Questions are : ");
            int q = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Question {0}", q);
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(questions[i, j]);
                }
                Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                try
                {
                    answers[i] = Console.ReadLine();
                    answers[i] = answers[i].ToLower();
                    q++;
                    Console.WriteLine();
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        //method for calculate marks
        void CalulateMark()
        {
            for (int i = 0; i < 10; i++)
            {
                if (answers[i] == crtAnswers[i])
                {
                    mark++;
                }
            }
        }
        //method for calculate grade
        void CalculateGrade()
        {
            if (mark >= 9)
            {
                Console.WriteLine("Grade of ID {0} is Green", candidateID);
            }
            else if (mark < 9 && mark > 5)
            {
                Console.WriteLine("Grade of ID {0} is Red", candidateID);
            }
            else
            {
                Console.WriteLine("Grade of ID {0} is Amber", candidateID);
            }
        }
        //method to call the methods
        public void Show()
        {
            Console.WriteLine(" Anudip Foundation (Life Transformed) ");
            Console.WriteLine(" C# Mcq Quiz ");
            GetCandidateDetails();
            InitQuestions();
            ShowQuestions();
            CalulateMark();
            Console.WriteLine();
            Console.WriteLine("{1}'s Mark is : {0}", mark, candidateName);
            CalculateGrade();
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            //Creating object for Test class
            Test test = new Test();
            //Calling show method
            test.Show();
        }
    }
}