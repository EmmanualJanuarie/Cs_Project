using System;//allows us to use the classes from the system

namespace calculator // used to organize the code
{
    class CalcMainDisplay: DemoClass
    // used to store data and methods, it brings functionality to the code
    {  
        //creating a method for the calculator main menu
        static void MainDisplay()
        {
            CalcMainDisplay calc_Dis = new CalcMainDisplay();
            Console.WriteLine("**************************");
            Console.WriteLine("      C# Calculator     ");
            Console.WriteLine("**************************");

            //Message to user
            Console.WriteLine("What would you like to do?");
            //Creating options for the user to choose from
            Console.WriteLine("1: Adding Two values");
            Console.WriteLine("2: Dividing Two values");
            Console.WriteLine("3: Subtracting Two values");
            Console.WriteLine("4: Multiplying Two values");

            //prompting user to select an option
            Console.WriteLine("");
            Console.WriteLine("Please select an option:");

            //creating a string variaable to allow user to input data
            string val1 = Console.ReadLine();
         

            //creating switch statement to handle directing between menus
            switch(val1)
            {
                case "1": 
                calc_Dis.Sum();
                break;

                //Creating case for dividing
                case "2":
                calc_Dis.Quotient();
                break;

                //creating case for Subtracting
                case "3":
                calc_Dis.Difference();
                break;

                //creating case for multiplying 
                case "4":
                Product();//this method calling is different, because we used static void 
                break;

                //DEFAULT OPTION
                default:
                Console.WriteLine("Please Choice from options!");
                //Calling the main menu
                MainDisplay();
                break;

            }

            

        }
        //adding the Main method to run codes
        static void Main(string[] args)
        {
            //Calling the calculators main display methods
            MainDisplay();
            
        }
        
    }

}
