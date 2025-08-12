using System;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace Task05
{
    internal class Program
    {

        public static void TestDefensiveCode()
        {
            double X, Y, Z;
            do
            {
                Console.WriteLine("Enter First Number: ");
            }
            while (!double.TryParse(Console.ReadLine(), out X) || X <= 0);

            do
            {
                Console.WriteLine("Enter Second Number: ");
            }
            while (!double.TryParse(Console.ReadLine(), out Y) || Y <= 1);

            Z = X / Y;
            Console.WriteLine($"Result of {X} / {Y} = {Z}");

            int[] arr = { 1, 2, 3 };
            if (arr?.Length > 2)
            {
                arr[2] = 76;
                Console.WriteLine("Array updated successfully.");
            }
        }

        public static void SumAndMultiply(double input1, double input2, out double sum, out double product)
        {
            sum = input1 + input2;
            product = input1 * input2;
        }

        public static void Print(string message, int times = 5)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(message);
            }
        }

        public static int SumArray(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        static void Main()
        {
            // PART 1

            #region Problem01
            /*
            try
            {
                Console.WriteLine("Enter the first num: ");
                int Num01 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second num: ");
                int Num02 = int.Parse(Console.ReadLine());

                int result = Num01 / Num02;
                Console.WriteLine($"The result of {Num01} / {Num02} is: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter valid integers.");
            }
            finally
            {
                Console.WriteLine("Problem Solved <3");
            }
            */
            #endregion

            #region Problem02
            // TestDefensiveCode();
            #endregion

            #region Problem03
            /*
            int? NullNum = null;
            int DefaultValue = NullNum ?? 4;

            Console.WriteLine($"NullNum: {NullNum}");
            Console.WriteLine($"DefaultValue: {DefaultValue}");

            if (NullNum.HasValue)
            {
                Console.WriteLine($"NullNum has a value: {NullNum.Value}");
            }
            else
            {
                Console.WriteLine("NullNum is null");
            }

            NullNum = 2004;

            Console.WriteLine($"\nAfter assigning Value: ");
            Console.WriteLine($"HasValue: {NullNum.HasValue}");
            Console.WriteLine($"Value: {NullNum.Value}");
            // HasValue returns a boolean whether it has value or not 
            // value returns the real value in the variable
            */
            #endregion

            #region Problem04
            /*
            int [] arr = { 1, 2, 3, 4, 5 };

            try
            {
                Console.WriteLine("plz enter the index you want to access. ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine($"accessing index {i} : Value is: " + arr[i]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("sorry, you are trying to access an out of range index ");
            }
            */
            #endregion

            #region Problem05
            /*
            int [,] arr = new int[3, 3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1);)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    bool flag = int.TryParse(Console.ReadLine(),out arr[i,j]);
                    if (flag)
                        j++;
                }

            }

            Console.WriteLine("\nthe Sum Of Rows is: ");
            for (int Row = 0; Row < arr.GetLength(0); Row++)
            {
                int RowSum = 0 ;
                for (int Col = 0; Col < arr.GetLength(1); Col++)
                {
                    RowSum += arr[Row, Col];
                }
                Console.WriteLine($"Row {Row}: {RowSum}");
            }

            Console.WriteLine("\nthe Sum Of Columns is: ");
            for (int Col = 0; Col < arr.GetLength(0); Col++)
            {
                int ColSum = 0;
                for (int Row = 0; Row < arr.GetLength(1); Row++)
                {
                    ColSum += arr[Row, Col];
                }
                Console.WriteLine($"Column {Col}: {ColSum}");
            }
            */
            #endregion

            #region Problem06
            /*
            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[4];
            arr[2] = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"\nEnter {arr[i].Length} values for row {i}:");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    while (!int.TryParse(Console.ReadLine(), out arr[i][j]))
                    {
                        Console.WriteLine("Invalid Input! plz enter an integer: ");
                    }
                }
            }

            Console.WriteLine("\n jagged array values: ");
            for (int row = 0; row < arr.Length; row++)
            {
                Console.WriteLine($"Row {row} : ");
                for (int col = 0; col < arr[row].Length; col++)
                {
                    Console.WriteLine($"Results: {arr[row][col]}");
                }
            }
            */
            #endregion

            #region Problem07
            /*
            #nullable enable
            string? Name = null;

            Console.Write("Plz Gimme ur name or dont :( \nName: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                Name = input;
            Console.WriteLine($"Entered Name Is : {Name}");
            #nullable disable
            */
            #endregion

            #region Problem08
            /*
            Console.WriteLine("Enter Value: ");
            int i = int.Parse(Console.ReadLine());
            object Boxing = i;
            Console.WriteLine($"Boxed value: {Boxing}");

            try
            {
                int Unboxing = (int)Boxing;
                Console.WriteLine($"Unboxed value: {Unboxing}");

                Console.WriteLine("\nAttempting invalid unboxing...");
                object text = "Hello";
                int wrongUnbox = (int)text;
                Console.WriteLine($"Unboxed wrong type: {wrongUnbox}");
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            */
            #endregion

            #region Problem09
            /*
            double Sum, Product;

            Console.WriteLine("Enter Two Values: ");
            double i = double.Parse(Console.ReadLine());
            double j = double.Parse(Console.ReadLine());

            SumAndMultiply(i, j, out Sum, out Product);
            Console.WriteLine($"Sum is: {Sum}");
            Console.WriteLine($"Product is: {Product}");
            */
            #endregion

            #region Problem10
            /*
            Print("Hello");
            Console.WriteLine();

            Print("Hi there", 3);
            Console.WriteLine();

            Print(message: "Named parameter ", times: 2);
            */
            #endregion

            #region Problem11
            /*
            int[]? arr = null;
            Console.WriteLine($"Array Length is: {arr?.Length}");

            arr = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Array Length After init is: {arr?.Length}");

            Console.WriteLine($"1st element is: {arr?[0]}");
            */
            #endregion

            #region Problem12
            /*
            Console.WriteLine("Enter a day: ");
            string Day = Console.ReadLine();
            int dayNumber = Day.ToLower() switch
            {
                "sunday" => 1,
                "monday" => 2,
                "tuesday" => 3,
                "wednesday" => 4,
                "thursday" => 5,
                "friday" => 6,
                "saturday" => 7,
            };
            Console.WriteLine($"Day number: {dayNumber}");
            */
            #endregion

            #region Problem13
            /*
            int sum1 = SumArray(1, 2, 3, 4, 5);
            Console.WriteLine($"Sum of each value is: {sum1}");

            int[] numbers = { 10, 20, 30, 40 };
            int sum2 = SumArray(numbers);
            Console.WriteLine($"Sum of array values: {sum2}");
            */
            #endregion

            // PART 2 

            #region Problem01
            /*
            Console.WriteLine("Enter a positive integer: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i < n)
                        Console.Write(i + ", ");
                    else
                        Console.Write(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
            */
            #endregion

            #region Problem02
            /*
            Console.WriteLine("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                for (int i = 1; i <= 12; i++)
                {
                    int result = num * i;
                    if (i < 12)
                        Console.Write(result + ", ");
                    else
                        Console.Write(result);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            */
            #endregion

            #region Problem03
            /*
            Console.WriteLine("Enter a positive integer: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
            {
                for (int i = 2; i <= n; i += 2)
                {
                    if (i < n && i + 2 <= n)
                        Console.Write(i + ", ");
                    else
                        Console.Write(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer greater than 1.");
            }
            */
            #endregion

            #region Problem04
            /*
            Console.WriteLine("Enter the base number: ");
            if (!int.TryParse(Console.ReadLine(), out int baseNum))
            {
                Console.WriteLine("Invalid base number.");
                return;
            }

            Console.WriteLine("Enter the exponent: ");
            if (!int.TryParse(Console.ReadLine(), out int exponent))
            {
                Console.WriteLine("Invalid exponent.");
                return;
            }

            long result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }

            Console.WriteLine($"{baseNum}^{exponent} = {result}");
            */
            #endregion

            #region Problem05
            /*
            Console.WriteLine("Enter a string: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No input provided.");
                return;
            }

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            Console.WriteLine($"Reversed string: {reversed}");
            */
            #endregion

            #region Problem06
            /*
            Console.WriteLine("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int reversed = 0;

                while (number != 0)
                {
                    int digit = number % 10;
                    reversed = reversed * 10 + digit;
                    number /= 10;
                }

                Console.WriteLine($"Reversed number: {reversed}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            */
            #endregion

            #region Problem07
            /*
            Console.WriteLine("Enter the size of the array: ");
            if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                Console.WriteLine("Invalid array size.");
                return;
            }

            int[] arr = new int[size];

            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < size; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Invalid input. Enter an integer:");
                }
            }

            int maxDistance = -1;
            int element = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        int distance = j - i - 1;
                        if (distance > maxDistance)
                        {
                            maxDistance = distance;
                            element = arr[i];
                        }
                        break;
                    }
                }
            }

            if (maxDistance >= 0)
            {
                Console.WriteLine($"Longest distance is {maxDistance} between two '{element}' elements.");
            }
            else
            {
                Console.WriteLine("No matching elements found.");
            }
            */
            #endregion

            #region Problem08
            /*
            Console.WriteLine("Enter a sentence: ");
            string? sentence = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(sentence))
            {
                string reversedSentence = string.Join(" ", sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
                Console.WriteLine(reversedSentence);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid sentence.");
            }
            */
            #endregion
        }
    }
}
