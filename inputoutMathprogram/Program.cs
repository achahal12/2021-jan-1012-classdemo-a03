using System;

namespace inputoutMathprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * implement a temperature converter from
             * celsius to Fahrenhit
             * 
             * Jun 2021
             */
            //input: celsius temperature
            //string InputTemp
            //double theCelsiusTemperature
            //double theFahrenheitTemperature

            //expression (calculate): (ct *(9.0/5.0)) +32
            //check with ct=0 expect ft = 32
            //check with ct= 100 expect ft =212
            //check with ct= -40 expect ft = -40

            //prompt for a celsius temperature
            // .write() keep your cursor on the same line
            Console.Write("Enter a celsius temperature:");

            //How does the program pull in the entery from the user
            //to obyain the key stokes that the user types (input)
            // .ReadLine()
            //importent!!!
            // data comes in to the program as a string 
            // DOES NOT matter if you enter a number, it is treat as
            //  a string
            
            //declare the variable:    datatype variablename;
            string inputTemp;
            // assignment statment:    expression on the right is placed
            //                          into the variable on the left
            // expression (action):     read the user input
            inputTemp = Console.ReadLine();

            // you could do both statments on the line
            // string input Temp = Console.ReadLinr();

            //currently the celsius value is a string
            // the value needs to be converted to a number to be
            //used in a math calculation
            //convert the data to a different datatype
            //to do this; you will use technique called parsing
            //  syntax:  datatypeTo.parse(string value)

            //WARNING: i am assuming the user will enter valid data
            //          if the user does not enter a number this program
            //          will abort on the execution of this line

            double theCelsiusTemperature = double.Parse(inputTemp);

            //calculation using the conversion expression
           
            double theFahrenheitTemperature =
            (theCelsiusTemperature * (9.0 / 5.0)) + 32;

            //output 
            // .writeLine() which automaticaly goed to th next line.
            Console.WriteLine($" the celsiue of { theCelsiusTemperature}) is "+

             $"{theFahrenheitTemperature}in Fahrenhit.");
        }
    }
}
 