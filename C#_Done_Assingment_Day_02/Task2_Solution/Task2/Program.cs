using System;
using System.IO;
using System.Transactions;

public class Employee
{
    public string Name;
}
namespace Task2
{
    class Program
    {
        static void Main()
        {


            #region problem1 

            //int x = 10; // create an intger variable and set its value to 10
            //int y = 20; // create an intger variable and set its value to 20
            //int sum = x + y;
            /*
             create a variable named sum and its type is integer
             then set its value to be the summation of the value stored in x and y 
            */
            //Console.WriteLine(sum); // prints the value stored in the sum variable
            #endregion

            #region Question1
            //Question: What is the shortcut to comment and uncomment a selected block of code in Visual Studio? 
            // ctrl + K + C --> to make a comment 
            // ctrl + K + U --> to make a uncomment
            #endregion

            #region problem2
            /*
            int x = "10";  --> value entered as a char not as an intger
            console.WriteLine(x + y); --> there is no variable named y so there is a logical error in that func 
            and c# is case senstivie --> console is wrong --> Console 
            */
            //solution 
            //int x = 10;
            //y = 20;
            //Console.WriteLine(sum=x+y);

            #endregion

            #region Question2
            //Question: Explain the difference between a runtime error and a logical error with examples. 
            /* 
            runtime error --> happens during execution and crash the program - and can be detected by debuging or trace line by line
            ex. x=5; y=0; sum= x/y; 
            logical error --> an error in the function design or in the logic that returns an unexpected or wrong output
            ex. RectangleArea = (5 + 7) --> it does not return the area (supposed to be like this 5*7)
             */
            #endregion

            #region problem3
            /*
            Your full name.            --> string FullName;
            Your age.                  --> int Age;
            Your monthly salary.       --> decimal MonthlySalary;
            Whether you are a student. --> bool Student;
            */
            //-----------Implementation--------------
            /*
            string FullName = "ahmed sherif naseem";
            Console.WriteLine(FullName);
            int Age = 21;
            Console.WriteLine(Age);
            decimal MonthlySalary = 7800;
            Console.WriteLine(MonthlySalary + "$");
            bool Student = true;
            Console.WriteLine("Are you a Student? " + Student);
            */
            #endregion

            #region Question3
            //Question: Why is it important to follow naming conventions such as PascalCase in C#? 
            /*
            1.Improves Code Readability
            2. Maintains Consistency and Easier Maintenance
            3. Follows .NET Standards
            */
            #endregion

            #region problem4
            /*
            Employee Emp1 = new Employee();
            Emp1.Name = "Ahmed";
            Employee Emp2 = Emp1;
            Emp2.Name = "Ashraf";
            Console.WriteLine("Employee1: " + Emp1.Name);
            Console.WriteLine("Employee2: " + Emp2.Name);
            */
            #endregion

            #region Questions4
            //Question: Explain the difference between value types and reference types in terms of memory allocation.
            /*
            Value Types: are stored on the stack and hold data directly --> the Actual data

            Reference Types: data are stored on the heap, with the variable on the stack holding a reference to the object --> holding the address of the data 
             */
            #endregion

            #region problem5
            /*
            int x = 15;
            int y = 4;
            int Sum = x+y;
            int Difference = x-y;
            int Product = x * y;
            double division = (double)x / y;
            int Remainder = x % y;
            Console.WriteLine("The Sum Is: "+Sum);
            Console.WriteLine("The Difference Is: "+Difference);
            Console.WriteLine("The Product Is: "+Product);
            Console.WriteLine("The division Is: "+division);
            Console.WriteLine("The Remainder Is: "+Remainder);
            */
            #endregion

            #region Question5
            //Question: What will be the output of the following code? Explain why: 
            /*
            int a = 2, b = 7;
            Console.WriteLine(a % b); // Output: 2 --> because 2 is less than 7 it cant be fully divided so 2 is the remainder
            */
            #endregion

            #region Problem6
            /*
            Console.WriteLine("Enter a Number");

            int test1 = Convert.ToInt32(Console.ReadLine());
            
            if (test1 > 10 && test1 % 2 == 0)
            {
                Console.WriteLine("The number is greater than 10 and even");
            }
            else
            {
                Console.WriteLine("The number is not greater than 10 or not even.");
            }
            */
            #endregion

            #region Question6
            //Question: How does the && (logical AND) operator differ from the & (bitwise AND) operator? 
            /*
             && --> used for boolen values but do the short circut --> if there is a false condition it wont loop or check the over values
             &  --> same as Logical AND but do not do the short circut --> it loops to check all values 
            */

            #endregion

            #region Problem7
            /*
            Console.WriteLine("Enter a Number");

            double Number = Convert.ToDouble(Console.ReadLine());

            // Explicit Casting
            int Number1 = (int) Number;

            // Implicit Casting
            double Number2 = (double)Number;

            Console.WriteLine("The Number You Have Entered: " + Number);
            Console.WriteLine("The Explicit Number: " + Number1);
            Console.WriteLine("The Implicit Number: " + Number2);
            */
            #endregion

            #region Question7
            //Question: Why is explicit casting required when converting a double to an int? 
            /*
            1. Potential Data Loss    --> because the double may store fractional values and the intger cant store fractions leading to data loss
            2. Not Safe Automatically --> due to the probability of data loss the compiler will not allow that convertion so it must made manually
            */
            #endregion

            #region Problem8
            /*
            Console.WriteLine("Enter Your Age: ");
            string StringAge = Console.ReadLine();
            int age = int.Parse(StringAge);
            if (age > 0)
            {
                Console.WriteLine("Your Age Is Valid And Its: " + age);
            }
            else
            {
                Console.WriteLine("The Age You Entered Is Not Valid!... Please Enter Your Real Age");
            }
            */
            #endregion

            #region Question8
            //Question: What exception might occur if the input is invalid and how can you handle it 
            /*
            1.FormatException       --> happens when the input data doesnot match its container data type
            2.ArgumentNullException --> happens when the input is null
            3.OverflowException     --> happens when the container cant contain a large number or a very small number to fit in
            */
            #endregion

            #region Problem9
            /*
            int x = 10;
            Console.WriteLine(x);   // prints the original value
            Console.WriteLine(x++); // prints the previously stored value then update the memory with the new value 
            Console.WriteLine(++x); // increment the value in the memory first then print it 
            */ 
            #endregion

            #region Question9
            //Question: Given the code below, what is the value of x after execution? Explain why
            /*
            int x = 5;
            int y = ++x + x++; // y = (++x --> which means x = 6 before print) + (x++ --> print the value of x first which is 6 then increment it and store its new value = 7 )
            Console.WriteLine(x); // the value of x = 7 because it get incremented by 1 twice  
            Console.WriteLine(y);
            */
            #endregion
        }
    }
}
