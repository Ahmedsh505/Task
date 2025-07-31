using System;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Emp
{
    public decimal salary;
}
namespace Task_03
{
    class Program
    {
        static void Main()
        {
            #region Problem_01
            /*
            Console.WriteLine("Enter Your Salary: ");
            string Salary = Console.ReadLine();
            try
            {
                int Salary01 = int.Parse(Salary);
                Console.WriteLine("Your Salary In int.Parse: " + Salary01);

                int Salary02 = Convert.ToInt32(Salary);
                Console.WriteLine("Your Salary In Convert.ToInt32: " + Salary02);

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: PLZ Enter A Valid Salary");
            }
            catch
            {
                Console.WriteLine("Error: The Salary Number Entered Is Too Small Or Too Large");
            }
            */
            #endregion

            #region Queston_01
            /*
            int.parse(Null)       --> ArgumentNullException 
            Convert.ToInt32(Null) --> Return 0 ---> it treats null as 0 
            */
            #endregion

            #region Problem_02
            /*
            Console.WriteLine("Enter a Number Sir : ");
            String Number = Console.ReadLine();

            int Check;
            if (int.TryParse(Number, out Check))
            {
                Console.WriteLine("The Number You Entered: " + Number);
            }
            else 
            {
                Console.WriteLine("Error: You Entered a Non Valid Number :( ");
            }
            */
            #endregion

            #region Question_02
            /*
            1- No Exception --> try prase return false on failure instead of throwing an exception
            2- Better UX    --> check the user input and returns a friendly feedback
            3- Performance  --> Exceptions costs much in .NET so its better to avoid it 
            4- Avoids Unexpected crashes
            */
            #endregion

            #region Problem_03
            /*
            object Test;
            
            Test = 4;
            Console.WriteLine("int: " + Test);
            Console.WriteLine("HashCode: " + Test.GetHashCode());
            
            Test = "Ahmed";
            Console.WriteLine("String: " + Test);
            Console.WriteLine("Hashcode: " + Test.GetHashCode());

            Test = 7800.3599;
            Console.WriteLine("Double: " + Test);
            Console.WriteLine("Hashcode: " + Test.GetHashCode());

            Test = 'A';
            Console.WriteLine("Char: " + Test);
            Console.WriteLine("Hashcode: " + Test.GetHashCode());
            */
            #endregion

            #region Question_03
            /*
            1- For Quick Lookups --> Fast Searching And Retrieving
            2- Used With Equals() --> To Narrow Down Number Of Candidates 
            */
            #endregion

            #region Problem_04
            /*
            Emp e = new Emp();
            e.salary = 7800;
            Console.WriteLine("Salary(e): " + e.salary );

            Emp g = new Emp();
            g = e;
            Console.WriteLine("Salary(g): " + g.salary);
            
            g.salary = 100000;
            Console.WriteLine("NewSalary(e): " + e.salary);
            Console.WriteLine("NewSalary(g): " + e.salary);
            */
            #endregion

            #region Question_04
            /*
            1- Determines if two variables point to the exact same object instance in memory
            2- Shared state --> chaning the value via one reference is visible through all other reference
            3- Critical in caching, memoization, and object tracking to avoid duplicating work for the same instance
            */
            #endregion

            #region Porblem_05
            /*
            string text = " Iam Ahmed, ";
            Console.WriteLine("Before Modification: " + text);
            Console.WriteLine("Before Modification: " + text.GetHashCode());

            text += "Hi Willy";
            Console.WriteLine("After Modification: " + text);
            Console.WriteLine("After Modification: " + text.GetHashCode());
            */
            #endregion

            #region Question_05
            /*
            1- Security --> Immutable strings prevent unexpected or malicious changes
            2- String interning and memory sharing --> The runtime can safely intern and share string instances because they can’t be modified
            3- Performance
            4- Thread safety
            */
            #endregion

            #region Problem_06
            /*
            StringBuilder text = new StringBuilder();
            
            text.Append("Hi Willy, ");
            Console.WriteLine("Before Modification: " + text);
            Console.WriteLine("Before Modification: " + text.GetHashCode());

            text.Append("Iam Ahmed");
            Console.WriteLine("After Modification: " + text);
            Console.WriteLine("After Modification: " + text.GetHashCode());
            */
            #endregion

            #region Question_06
            /*
            1- Immutable strings cause repeated allocations: Every string concatenation 
            creates a new string and copies existing contents, 
            leading to many temporary objects and wasted memory/time

            2- stringbuilders can append new text to the string without wasting memory or making ueless copies
            */
            #endregion

            #region question_07
            /*
            1- Mutable internal buffer: StringBuilder modifies content in place 
            instead of creating a new string on each change. 
            2- Storage O(1)
            3- Avoids repeated copying as happens in string
            */
            #endregion

            #region Problem_07
            /*
            Console.WriteLine("Enter The first Number: ");
            double input1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Number: ");
            double input2 = double.Parse(Console.ReadLine());

            double sum =input1 + input2;
            Console.WriteLine("Sum is " + input1 + "+" + input2 + ": " + sum);
            Console.WriteLine(string.Format("Sum is {0}+{1}: {2}", input1, input2, sum));
            Console.WriteLine($"Sum is {input1}+{input2}: {sum}");
            */
            #endregion

            #region Question_08
            /*
            1- Readability
            2- Less error-prone
            3- Performance 
            4- Concise --> Shorter and cleaner than string.Format or manual concatenation
            */
            #endregion

            #region Problem_08
            /*
            StringBuilder text = new StringBuilder();
            text.Append("Iam Sherif");
            Console.WriteLine("After Append: " + text);

            text.Replace("Sherif", "Ahmed ");
            Console.WriteLine("After Replace: " + text);

            text.Insert(10, "a 21 yo student ");
            Console.WriteLine("After insert: " + text);

            text.Remove(12, 6);
            Console.WriteLine("After removing: " + text);
            */
            #endregion

            #region Question_09
            /*
            1- Immutability vs. Mutability
            -string -> Immutable Any modification creates a new string and copies data
              So doing repeated operations causes many allocations and copies.

            -StringBuilder -> Mutable It maintains an internal character buffer and modifies that buffer 
              No new string is allocated on each operation
            */
            #endregion

        }
    }
}
