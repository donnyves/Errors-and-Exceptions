using System;

namespace Exercise_3A___Errors_and_Exceptions
{
    class Exercise3A            
    {        
        static void Main(string[] args)
        {        
            //In the try block, the calucalations are processed and if their is an issue, it
            //is resolved in the catch block.
            try
            {
                //Overflow is an operation that occurs when a calculation produces
                //a result that is greater in magnitude than that
                //which a given register or storage location can store
                // or represent.
                double doubleValue = Double.MaxValue;
                double overflow = doubleValue + 1;
                Console.WriteLine($"intValue: {doubleValue}");
                Console.WriteLine($"overflow: {overflow}");

                Console.WriteLine("Type in the value for the radius, to calculate the Area of a Circle, and press enter: ");
                double userInput = Int32.Parse(Console.ReadLine());
                double answerAreaCircle = AreaOfCircle(userInput);
                Console.WriteLine($"{answerAreaCircle}");

                Console.WriteLine();

                Console.WriteLine("Type in a value for the radius, to calculate the Circumference of a Circle, and press enter: ");
                double userInput1 = Int32.Parse(Console.ReadLine());
                double answerAreaCircumference = CircumferceCircle(userInput1);
                Console.WriteLine($"{answerAreaCircumference}");

                Console.WriteLine();

                Console.WriteLine("Type in a value for the radius, to calculate the volume of a hemisphere, and press enter: ");
                double userInput2 = Int32.Parse(Console.ReadLine());
                double answerVolume = VolumeOfHemishere(userInput2);
                Console.WriteLine($"{answerVolume}");

                Console.WriteLine();

                double a, b, c, p, area;
                Console.Write("Enter the value for the Length of a Triangle's three sides, press enter after each value typed: ");
                Console.WriteLine();
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                p = (a + b + c) / 2;
                area = (double)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Area of the triagle is: ");
                Console.WriteLine(area);
                Console.WriteLine();
                Console.WriteLine("Press Enter");
                Console.ReadLine();

                quadraticFormula();
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by 0.");              
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please type in an integer.");
                Console.ReadLine();
             
                
            }
            //I GOT THIS TO WORK!!!!  I put the Double.MaxValue in the try block
            // and put in my max range for a double.   
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception");
                Console.ReadLine();
            }

            finally
            {
                Console.WriteLine("This program has finally terminated.");
            }
           

        }
        public static double AreaOfCircle(double radius = 2)
        {
            return Math.PI * (radius * radius);
        }

        public static double CircumferceCircle(double radius)
        {
            return 2 * radius * Math.PI;
        }

        public static double VolumeOfHemishere(double radius)
        {
            return ((4 / 3) * Math.PI * Math.Pow(radius, 3) / 2);
        }
        public static double quadraticFormula(double a = 1, double b = 8, double c = 4)
        {

           
            double d, x1, x2;
            Console.Write("Calculate root of Quadratic Equation :\n");
            Console.Write("\n\n");

            Console.Write("Input the value of a : ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the value of b : ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the value of c : ");
            c = Convert.ToDouble(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.Write("Both roots are equal.\n");
                x1 = -b / (2.0 * b);
                x2 = x1;
                Console.Write("First  Root Root1= {0}\n", x1);
                Console.Write("Second Root Root2= {0}\n", x2);
            }
            else if (d > 0)
            {
                Console.Write("Both roots are real and diff-2\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("First  Root Root1= {0}\n", x1);
                Console.Write("Second Root root2= {0}\n", x2);
            }
            else
                throw new ArgumentException("Root are imaginary;\nNo Solution. \n\n");
            Console.ReadLine();

            return d;

        }

    }
}
