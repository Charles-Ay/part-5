using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_5
{
    
    class Program
    {
       

        static void Main(string[] args)
        {
            
            int grade;
            string gradeS;
            string guess;
            int guessNum;
            string radi;
            int Radius;
            int between;
            string betweenS;


            Console.WriteLine("What grade did you get?");
            gradeS = Console.ReadLine();
            grade = Convert.ToInt32(gradeS);

            if (grade >= 80)
            {
                Console.WriteLine("Good Job");
            }
            else
            {
                Console.WriteLine("Study harder");
            }
            
            Console.WriteLine("guess a number bettween 10 and 20");
            guess = Console.ReadLine();
            guessNum = Convert.ToInt32(guess);

            if (guessNum == 12)
            {
                Console.WriteLine("You guessed it");
            }
            else
            {
                Console.WriteLine("Try Again");
            }

            Console.WriteLine("Enter a Radius");
            radi = Console.ReadLine();
            Radius = Convert.ToInt32(radi);

            if (Radius > 0)
            {
                Console.WriteLine($"The Diameter is: {Radius * 2}");
            }
            else if (Radius == 0)
            {
                Console.WriteLine("You have a dot");
            }
             else
            {
                Console.WriteLine($"Negative raddii are illegal");
            }

            Console.WriteLine("Enter a number");
            betweenS = Console.ReadLine();
            between = Convert.ToInt32(betweenS);

            if (between > 4 && between < 16)
            {
                Console.WriteLine("In between");
            }
            else
            { 
                Console.WriteLine("Not between");
            }
        }
    }
}
