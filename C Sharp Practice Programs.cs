namespace FizzBuzz
{

    public class MyClass
    {


        static void Main(string[] args)
        {
            MyClass classTest = new MyClass();
            
            Console.WriteLine("**********C# Practice Exercises**********");
            Console.WriteLine("1. Print the sum of two numbers");
            Console.WriteLine("2. Print a number's multiplication table.");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Basic Algorithms:");
            Console.WriteLine("3. Print sum of two numbers, if they are the same print triple the value.");
            Console.WriteLine("4. Check a number and return true if it is within 10 of 100 or 200.");
            Console.WriteLine("5. Check if a input starts with 'C#' or not");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Loops:");
            Console.WriteLine("6. Display the first 10 natural numbers.");
            Console.WriteLine("7. Right angle triangle using an asterisk");
            Console.WriteLine("8. Right angle triangle with a number which will repeat a number in a row.");
            Console.WriteLine("9. Calculate the factorial of a given number");
            Console.WriteLine("10. ");
            Console.WriteLine("---------------------------------");
            classTest.ProgramChoice();
        }

        private void ProgramChoice()
        {
            Console.WriteLine("Please choose a program: (Only type number)");
            int intChoice = IntParse();
            Console.WriteLine("--------------------------------------------------------");
            if (intChoice == 1) 
            {
                // 1. Write a C# Sharp program to print the sum of two numbers
                Console.WriteLine("Type first number:");
                decimal firstNumber = DecimalParse();
                Console.WriteLine("Type second number:");
                decimal secondNumber = DecimalParse();
                string numberSum = (firstNumber + secondNumber).ToString();
                Console.WriteLine(numberSum);

            }
            if (intChoice == 2)
            {
                // 2. Write a C# Sharp program that takes a number as input and print its multiplication table.
                Console.WriteLine("Multiplication Table:");
                Console.WriteLine("Enter number:");
                int multiplyNumber = IntParse();
                for (int i = 0; i <= 50; i++)
                {
                    string strMultiply = multiplyNumber.ToString() + " * " + i.ToString() + " = ";

                    Console.WriteLine(strMultiply + (multiplyNumber * i).ToString());
                }
            }
            if (intChoice == 3)
            {
                // 3. Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum 
                Console.WriteLine("3. Print sum of two numbers, if they are the same print triple the value.");
                Console.WriteLine("Please enter a whole number:");
                int firstNumber = IntParse();
                Console.WriteLine("Please enter a whole number:");
                int secondNumber = IntParse();
                string result = "";
                if (firstNumber==secondNumber)
                {
                    Console.WriteLine("Numbers are same; sum will be tripled:");
                    result = "Sum:" + ((firstNumber + secondNumber) * 3).ToString();
                }
                else
                {
                    Console.WriteLine("Numbers are different; result will be sum:");
                    result = "Sum:" + (firstNumber + secondNumber).ToString();
                }

                Console.WriteLine(result);

            }
            if (intChoice == 4)
            {
                Console.WriteLine("4. Check a number and return true if it is within 10 of 100 or 200.");
                int number = IntParse();
                if ((number>=90&&number<=110)||(number >= 190 && number <= 210))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            if (intChoice == 5)
            {
                Console.WriteLine("5. Check if a input starts with 'C#' or not");
                string userInput = Console.ReadLine();
                string firstTwoChar = userInput.Substring(0, 2);
                if (firstTwoChar == "C#")
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            if (intChoice == 6)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            if (intChoice == 7)
            {
                Console.WriteLine("7. Right angle triangle using an asterisk");
                for (int i = 0; i < 5; i++)
                {
                    int loop = 0;
                    string asterisk = "";
                    while (i!=loop)
                    {
                        loop += 1;
                        asterisk += "*";
                    }

                    Console.WriteLine(asterisk);
                }
            }
            if (intChoice == 8)
            {
                Console.WriteLine("8. Right angle triangle with a number which will repeat a number in a row.");
                for (int i = 0; i < 5; i++)
                {
                    int loop = 0;
                    string number = "";
                    while (i != loop)
                    {
                        loop += 1;
                        number += i.ToString();
                    }
                    Console.WriteLine(number);
                }
            }
            if (intChoice == 9)
            {
                Console.WriteLine("8. Calculate the factorial of a given number");
            }

            PickAnother();
        }

        // Create method to convert user input (string) to decimal with fail safe for input other than numbers
        private decimal DecimalParse()
        {
            decimal decConvert = 0;
            bool blTryConvert = false;
            // loop to reenter invalid input
            while (!blTryConvert)
            {
                try
                {
                    decConvert = decimal.Parse(Console.ReadLine());
                    blTryConvert = true;
                }
                catch
                {
                    Console.WriteLine("Please enter number.");
                } 
            }
            // return converted decimal
            return decConvert;
        }

        private int IntParse()
        {
            int intConvert = 0;
            bool blTryConvert = false;
            // loop code block if bool is not true 
            while (!blTryConvert)
            {
                try
                {
                    intConvert = Convert.ToInt32(Console.ReadLine());
                    blTryConvert = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a whole number number.");
                }
            }
            return intConvert;
        }

        private void PickAnother()
        {
            Console.WriteLine("");
            Console.WriteLine("Would you like to select another program?");
            Console.WriteLine("Enter 1 for Yes or 2 for No.");
            int choice = IntParse();
            if (choice == 1)
            {
                ProgramChoice();
            }
            else if (choice == 2) 
            {
                Console.WriteLine("Thanks for using my program!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please pick a valid number.");
                PickAnother();
            }
        }
    }

}
