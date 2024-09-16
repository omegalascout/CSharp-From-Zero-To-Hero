using System;
using System.Globalization;
using System.Xml.Linq;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int itterations = 0;//this is to control how many times the program loops
                while (itterations < 2)
                {
                    CultureInfo culture = null;// I wanted to be able to make this code work with both the metric, and the imperial systems of measurement, so I added some
                                               // culture nodes(?) to be able to select what system of measurement is used when entering your weight and height
                    Console.Write("What is your name?: ");
                    string name = Console.ReadLine();
                    Console.Write("What is your age?: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    //these are some variables in charge of converting weight and height into their respective cultural formats, and then some variables for printing them
                    //with units of measurements in mind.
                    double weightConversion;
                    double heightConversion;
                    string weightPrint;
                    string heightPrint;
                    int som; //abreviated for system of measurement, used in if/else blocks in order to change the units used in questions
                    while (true) // while true block used to ensure that the user either inputs 1 or 2 for using the metric or imperial systems
                    {
                        Console.WriteLine("What is your system of measurement: ");
                        Console.Write("Metric = [1] | Imperial = [2]: ");
                        string keyChoice = Console.ReadLine();
                        switch (keyChoice)
                        {
                            case "1":
                                culture = CultureInfo.CreateSpecificCulture("en-GP");
                                som = 1;
                                break;
                            case "2":
                                culture = CultureInfo.CreateSpecificCulture("en-US");
                                som = 2;
                                break;
                            default:
                                Console.WriteLine("That isn't a valid key number, enter 1 or 2");
                                continue;
                        }
                        break;

                    }
                    if (som == 1) //if else block used for asking unit sensitive questions regarding weight and height, also used to change the BMI formula,
                                  //and to increase the itterations count to loop the code an additional time.
                    {
                        Console.WriteLine("What is your weight in kilograms?: ");
                        Console.Write("kg: ");
                        string weight = Console.ReadLine();
                        weightConversion = Double.Parse(weight, culture);
                        weightPrint = (weightConversion + " kg");
                        Console.WriteLine("What is your height in centimeters?: ");
                        Console.Write("cm: ");
                        string height = Console.ReadLine();
                        heightConversion = Double.Parse(height, culture);
                        heightPrint = (heightConversion + " cm");
                        Console.WriteLine("{0} is {1} years old, his weight is {2} and their height is {3}.", name, age, weightPrint, heightPrint);
                        double BMI = ((weightConversion / heightConversion / heightConversion) * 10000);
                        Console.WriteLine("Their BMI is " + BMI);
                        itterations++;
                    }
                    else
                    {
                        Console.WriteLine("What is your weight in lbs?: ");
                        Console.Write("lbs: ");
                        string weight = Console.ReadLine();
                        weightConversion = Double.Parse(weight, culture);
                        weightPrint = (weightConversion + " lbs");
                        Console.WriteLine("What is your height in feet and inches?: ");
                        Console.Write("feet: ");
                        int feet = Convert.ToInt32(Console.ReadLine());
                        Console.Write("inches: ");
                        double inches = Convert.ToDouble(Console.ReadLine());
                        string height = Convert.ToString((feet * 12) + inches);
                        heightConversion = Double.Parse(height, culture);
                        heightPrint = (heightConversion + " inches");
                        Console.WriteLine("{0} is {1} years old, their weight is {2} and their height is {3} feet and {4} inches.", name, age, weightPrint, feet, inches);
                        double BMI = (weightConversion / (heightConversion * heightConversion) * 703);
                        Console.WriteLine("Their BMI is " + BMI);
                        itterations++;

                    }
                }
            }
        }
    }
}