using System.Runtime.InteropServices;

class DemoClass: IAddition
{
    // DemoClass myClass = new DemoClass();
    //-----------------------FABRICATION OF SUM METHOD [START]--------------------------------//
  public void Sum()//must be set to public to allow connection to interface
       {
        Console.WriteLine("**************************");
        Console.WriteLine("         ADDITION         ");
        Console.WriteLine("**************************");

        //Message to tell user what they have selected
        Console.WriteLine("You have selected to Add two numbers");
        Console.WriteLine();//Respresents spacing
        //Ask user to enter first Number
        Console.WriteLine("Please enter your first number:");
        String strFisrtNum = Console.ReadLine();//allow to user to enter values into the created string above

        //Ask user to enter Second Number
        Console.WriteLine("Please enter your Second Number");
        String strSecNum = Console.ReadLine();//allow to user to enter values into the created string above

        //Converting the two strings so that it can be added
        int intFirstNum = int.Parse(strFisrtNum);
        int intSecNum = int.Parse(strSecNum);

        //Calculating the sum of two given numbers
        int quotient = intFirstNum + intSecNum;

        Console.WriteLine();//Respresents spacing
        //Printing the enter to the user
        Console.WriteLine("Calculation: "+intFirstNum + " "+ "+" + " " + intSecNum);

        Console.WriteLine();//Respresents spacing
        //printing the answer of ther sum
         Console.WriteLine("______________________");//dividers
        Console.WriteLine("Result: " + quotient); 
        Console.WriteLine("______________________");//dividers
       }
    //-----------------------FABRICATION OF SUM METHOD [END]--------------------------------//

    //-----------------------FABRICATION OF QUOTIENT METHOD [START]--------------------------------//
    public void Quotient()//must be set to public to allow connection to interface
       {
        try{
        Console.WriteLine("**************************");
        Console.WriteLine("         DIVISION         ");
        Console.WriteLine("**************************");

        //Message to tell user what they have selected
        Console.WriteLine("You have selected to divide two numbers");
        Console.WriteLine();//Respresents spacing
        //Ask user to enter first Number
        Console.WriteLine("Please enter your first number:");
        String strFisrtNum = Console.ReadLine();//allow to user to enter values into the created string above

        //Ask user to enter Second Number
        Console.WriteLine("Please enter your Second Number");
        String strSecNum = Console.ReadLine();//allow to user to enter values into the created string above

        //Converting the two strings so that it can be added
        int intFirstNum = int.Parse(strFisrtNum);
        int intSecNum = int.Parse(strSecNum);

        //Fabricating a conditional statement to handle arithmetic error
        if(intFirstNum == 0 || intSecNum == 0)
        {
            throw new ArgumentException("Can't divide by zero");
        }

        //Calculating the sum of two given numbers
        int sum = intFirstNum / intSecNum;

        Console.WriteLine();//Respresents spacing
        //Printing the enter to the user
        Console.WriteLine("Calculation: "+intFirstNum + " "+ "/" + " " + intSecNum);

        Console.WriteLine();//Respresents spacing
        //printing the answer of ther sum
         Console.WriteLine("______________________");//dividers
        Console.WriteLine("Result: " + sum); 
        Console.WriteLine("______________________");//dividers
        }catch(ArgumentException e)
        {
            Console.WriteLine("Error expected:" + e.Message);
        }
     
       }

    //-----------------------FABRICATION OF SUM METHOD [END]--------------------------------//

    //-----------------------FABRICATION OF DIFFERENCE METHOD [START]--------------------------------//
    public void Difference()
    {
         Console.WriteLine("**************************");
        Console.WriteLine("         SUBTRACTION         ");
        Console.WriteLine("**************************");

        //Message to tell user what they have selected
        Console.WriteLine("You have selected to subtract two numbers");
        Console.WriteLine();//Respresents spacing
        //Ask user to enter first Number
        Console.WriteLine("Please enter your first number:");
        String strFisrtNum = Console.ReadLine();//allow to user to enter values into the created string above

        //Ask user to enter Second Number
        Console.WriteLine("Please enter your Second Number");
        String strSecNum = Console.ReadLine();//allow to user to enter values into the created string above

        //Converting the two strings so that it can be added
        int intFirstNum = int.Parse(strFisrtNum);
        int intSecNum = int.Parse(strSecNum);

        //Calculating the sum of two given numbers
        int difference = intFirstNum - intSecNum;

        Console.WriteLine();//Respresents spacing
        //Printing the enter to the user
        Console.WriteLine("Calculation: "+intFirstNum + " "+ "-" + " " + intSecNum);

        Console.WriteLine();//Respresents spacing
        //printing the answer of ther sum
         Console.WriteLine("______________________");//dividers
        Console.WriteLine("Result: " + difference); 
        Console.WriteLine("______________________");//dividers
    }
    //-----------------------FABRICATION OF DIFFERENCE METHOD [END]--------------------------------//

    //-----------------------FABRICATION OF PRODUCT METHOD [START]--------------------------------//
    public static void Product()
    {
       Console.WriteLine("**************************");
        Console.WriteLine("     MULTIPLICATION      ");
        Console.WriteLine("**************************");

        //Message to tell user what they have selected
        Console.WriteLine("You have selected to multiply two numbers");
        Console.WriteLine();//Respresents spacing
        //Ask user to enter first Number
        Console.WriteLine("Please enter your first number:");
        String strFisrtNum = Console.ReadLine();//allow to user to enter values into the created string above

        //Ask user to enter Second Number
        Console.WriteLine("Please enter your Second Number");
        String strSecNum = Console.ReadLine();//allow to user to enter values into the created string above

        //Converting the two strings so that it can be added
        int intFirstNum = int.Parse(strFisrtNum);
        int intSecNum = int.Parse(strSecNum);

        //Calculating the sum of two given numbers
        int product = intFirstNum * intSecNum;

        Console.WriteLine();//Respresents spacing
        //Printing the enter to the user
        Console.WriteLine("Calculation: "+intFirstNum + " "+ "*" + " " + intSecNum);

        Console.WriteLine();//Respresents spacing
        //printing the answer of ther sum
         Console.WriteLine("______________________");//dividers
        Console.WriteLine("Result: " + product); 
        Console.WriteLine("______________________");//dividers
    }

    //-----------------------FABRICATION OF PRODUCT METHOD [END]--------------------------------//
}