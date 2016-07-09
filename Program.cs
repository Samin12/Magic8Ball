using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Magic8Ball
{
    //class Samin
    //{
    //    static string name = "samin";
    //    static int age = "19";
    //    public static string alias = "cat";

    //}
/// <summary>
/// Magic8Ball entry
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            

            //Preserve currnet console text color 
            ConsoleColor oldColor = Console.ForegroundColor;

            Magic8Ball();

           

            // create a randomizer object
            Random RO1 = new Random();


            //loop forever
            while (true)
            {

                string questionsString = GetQuestion();

                int SleepTime = RO1.Next(2) + 1;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Thinking...");
                Thread.Sleep(SleepTime*1000);
                

                //see if the user typed quit as the question 
                if ( questionsString.ToLower() == "quit")
                {
                    break;
                    Console.WriteLine("Fuck you!");
                }

                if ( questionsString.ToLower() == "")
                {
                    Console.WriteLine("Write a question you piece of shit!");
                    continue;
                }

                if (questionsString.ToLower() == "you suck")
                {
                    Console.WriteLine("No! Fuck you");
                    break;
                }


                int RNum = RO1.Next(3);

                Console.ForegroundColor = (ConsoleColor)RO1.Next(15);
                
                //Use random number to deternube resoibse 
                switch(RNum)
                {
                    case 0:
                        {
                            
                            Console.WriteLine("Outlook Likely");
                            break;
                        }
                    case 1:
                        {
                            
                            Console.WriteLine("Outlook Not So Good");
                            break;
                        }
                    case 2:
                        {
                           
                            Console.WriteLine("You Smell Like shit Go away plz.");
                            break;
                        }
                    


                }


               
            }




            // CLeaning up
            Console.ForegroundColor = oldColor;

        }

        static void Magic8Ball()
        {
            // change current text color
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Magic ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("8 ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ball");

        }

        //reqturn the text
        static string GetQuestion()
        {

            Random RO1 = new Random();

            //THis asks a question and stores the quetsion in questionString Variable
            Console.ForegroundColor = (ConsoleColor)RO1.Next(15); 
            Console.Write("Ask a question?: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string questionsString = Console.ReadLine();

            return questionsString; 
        }
    }
}
