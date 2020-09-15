using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("What`s your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Int32.Parse(Console.ReadLine());
            if (age <= 20)
            {
                Console.WriteLine("You`re too young to use the calculator");
            }
            else if (age >= 60)
            {
                Console.WriteLine("You`re too old to use the calculator");
            }
            else
            {
                Console.WriteLine("You`re old enough");
            } 
              
            
             double BMI;
             double height;
             int weight;
              
                Console.WriteLine("how much do you weigh?");
                weight = int.Parse(Console.ReadLine());
                Console.WriteLine("How tall are you in metres?");
            height = double.Parse(Console.ReadLine());
                BMI = (weight / (height * height));
            Console.WriteLine($"Your BMI is {BMI}");

            if (BMI < 19)
            {
                Console.WriteLine("underweight");


            }
            else if (BMI >= 24.9)
            {
                Console.WriteLine("normal weight");


            }
            else if (BMI >= 29.9)
            {
                Console.WriteLine("overweight");
            }
            else if (BMI >= 30)
            {
                Console.WriteLine("obese");
            }

             
                
            

                


            











        }
    }
}
