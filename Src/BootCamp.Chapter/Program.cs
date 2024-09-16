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
                int itterations = 0;
                while (itterations < 2)
                {
                    CultureInfo culture = null;
                    Console.Write("What is your name?: ");
                    string name = Console.ReadLine();
                    Console.Write("What is your age?: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    double weightConversion;
                    double heightConversion;
                    string weightPrint;
                    string heightPrint;
                    int som;
                    while (true)
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
                    if (som == 1)
                    {
                        Console.WriteLine("What is your weight?: ");
                        Console.Write("kg: ");
                        string weight = Console.ReadLine();
                        weightConversion = Double.Parse(weight, culture);
                        weightPrint = (weightConversion + " kg");
                        Console.WriteLine("What is your height?: ");
                        Console.Write("cm: ");
                        string height = Console.ReadLine();
                        heightConversion = Double.Parse(height, culture);
                        heightPrint = (heightConversion + " cm");
                        Console.WriteLine("{0} is {1} years old, his weight is {2} and his height is {3}.", name, age, weightPrint, heightPrint);
                        double BMI = ((weightConversion / heightConversion / heightConversion) * 10000);
                        Console.WriteLine("His BMI is " + BMI);
                        itterations++;
                    }
                    else
                    {
                        Console.WriteLine("What is your weight?: ");
                        Console.Write("lbs: ");
                        string weight = Console.ReadLine();
                        weightConversion = Double.Parse(weight, culture);
                        weightPrint = (weightConversion + " lbs");
                        Console.WriteLine("What is your height?: ");
                        Console.Write("inches: ");
                        string height = Console.ReadLine();
                        heightConversion = Double.Parse(height, culture);
                        heightPrint = (heightConversion + " inches");
                        Console.WriteLine("{0} is {1} years old, his weight is {2} and his height is {3}.", name, age, weightPrint, heightPrint);
                        double BMI = (weightConversion / (heightConversion * heightConversion) * 703);
                        Console.WriteLine("His BMI is " + BMI);
                        itterations++;
                    }
                }
            }
        }
    }
}