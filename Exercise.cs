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
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
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
            Console.WriteLine();

            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1} ! I'm glad to inform you that you are the test subject of my very first assignment!", firstName, lastName);
        }

        private static void RunExerciseTwo()
        {
            Console.WriteLine("You successfully ran Exercise two!");
            Console.WriteLine();

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

        private static void RunExerciseFour()
        {
            Console.WriteLine("You successfully ran Exercise Four!");
            Console.WriteLine();

            string str = "The quick fox Jumped Over the DOG";
            string newStr;

            newStr = str.Replace("quick", "Brown");
            Console.WriteLine($"The source string is <{str}>");
            Console.WriteLine($"The updated string using Replace Method is <{newStr}>");
            Console.WriteLine();

            newStr = newStr.Insert(30, "lazy ");
            Console.WriteLine($"The source string is <{str}>");
            Console.WriteLine($"The updated string after using Insert Method is <{newStr}>");
            Console.WriteLine();

            string toRemove = "Jumped ";
            string result = string.Empty;
            int i = str.IndexOf(toRemove);
            if (i >= 0)
            {
                result = str.Remove(i, toRemove.Length);
            }
            Console.WriteLine($"The source string is <{str}>");
            Console.WriteLine($"The updated string after using Remove and IndexOf Method is <{result}>");
            Console.WriteLine();
        }

        private static void RunExerciseFive()
        {
            Console.WriteLine("You successfully ran Exercise Five!");
            Console.WriteLine();
            char[] charSeparators = new char[] { ',' };

            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            string newStr;
            int found = 0;

            
            found = str.IndexOf("[1,2,3,4,5]");
            newStr = str.Substring(found);
            Console.WriteLine($"The source string is <{str}>");
            Console.WriteLine("The new string is {0}", newStr);
            Console.WriteLine();

            
            string result = string.Empty;
            result = newStr.Remove(3,4);

            Console.WriteLine($"The string is <{newStr}>");
            Console.WriteLine($"The updated string after Removing 2 and 3 is <{result}>");
            Console.WriteLine();

            Console.WriteLine($"The string is <{result}>");

            newStr = result.Insert( 6, ", 6, 7, 8, 9, 10") ;
            //string joinedNewStr = string.Join(",", newStr);
            //newStr.Split(charSeparators);


            Console.WriteLine($"The updated string after Inserting 6-10 comma separated is <{newStr}>");
            Console.WriteLine();

        }
    }
}
