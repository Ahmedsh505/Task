using System;

namespace Task06
{
    
    internal class Program
    {
        static void ModifyStruct(Point p)
        {
            p.X = 100;
            p.Y = 200;
        }

        static void ModifyClass(Employee02 e)
        {
            e.EmpId = 10;
            e.Name = "Sheriff";
            e.Salary = 5400m;
        }
        static void Main()
        {
            #region Problem01
            /*
            Point p1 = new Point();
            Console.WriteLine(p1);

            Point p2 = new Point(1, 2);
            Console.WriteLine(p2);
            */
            #endregion

            #region Problem02
            /*
            TypeA obj = new TypeA(1, 2, 3);
           
            //Console.WriteLine($"F: {obj.F}"); //Private
            Console.WriteLine($"G: {obj.G}"); //Internal
            Console.WriteLine($"H: {obj.H}"); //Public

            obj.RetrieveValues();
            */
            #endregion

            #region Problem03
            /*
            Employee emp = new Employee(1, "Ahmed", 7600m);

            emp.DisplayEmpInfo();

            emp.SetName("Sheriff");// Using Setter
            emp.EmployeeId = 2;// Using Property
            emp.EmployeeSalary = 12000m;// Using Property

            emp.DisplayEmpInfo();
            */
            #endregion

            #region Problem04
            /*
            Point p3 = new Point(2);
            p3.DisplayPoint();

            Point p4 = new Point(3, 4);
            p4.DisplayPoint();
            */
            #endregion

            #region Problem05
            /*
            Point p1 = new Point(3, 4);
            Point p2 = new Point(7, 0);
            Point p3 = new Point(-2, 5);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            */
            #endregion

            #region Problem06
            /*
            Point StructPoint = new Point(10, 20);
            Employee02 ClassEmp = new Employee02(4, "Ahmed", 9865);

            Console.WriteLine("Before Calling Methods: ");
            Console.WriteLine("Struct: ");
            StructPoint.DisplayPoint();
            Console.WriteLine("Class Employee: ");
            ClassEmp.DisplayEmp02Info();

            ModifyStruct(StructPoint);
            ModifyClass(ClassEmp);

            Console.WriteLine("\nAfter Calling Methods: ");
            Console.WriteLine("Struct: ");
            StructPoint.DisplayPoint();
            Console.WriteLine("Class Employee: ");
            ClassEmp.DisplayEmp02Info();
            */
            #endregion
        }
    }
}
