using System;

namespace Exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.WriteLine("Enter assignment number ( or -1 to Exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a vaild assignment number!");
                            break;

                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a vaild assignment number!");
                    Console.ResetColor();
                }
            }


        }

        private static void RunExerciseOne()
        {
            Console.WriteLine("You successfully ran Exercise one!");

            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1} ! I'm glad to inform you that you are the test subject of my very first assignment!", firstName, lastName);
        }

        private static void RunExerciseTwo()
        {
            Console.WriteLine("You successfully ran Exercise two!");

            DateTime today = DateTime.Now;
            DateTime tomorrow = DateTime.Today.AddDays(1);
            DateTime yesterday = DateTime.Today.AddDays(-1);

            Console.WriteLine("Todays date is {0}", today);
            Console.WriteLine("Tomorrows date is {0}", tomorrow);
            Console.WriteLine("Yesterdays date was {0}", yesterday);
        }
        
          private static void RunExerciseThree()
        {
            Console.WriteLine("You successfully ran Exercise Three!");
            Console.WriteLine();

            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            string fname = firstName;


            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            string lname = lastName;
        }
    }
}
