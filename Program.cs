/* 
 * Author: Gursimran Kaur
 * Course: COMP-003A
 * Purpose:COMP003A.ASSIGNMENT
 */

namespace COMP003.ASSIGNMENT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numeric Grade(0-100):");
            double numericGrade = Convert.ToDouble(Console.ReadLine());

            if (numericGrade >= 0 && numericGrade <= 100)
            {
                if (numericGrade >= 90)
                    Console.WriteLine("Letter Grade: A");
                else if (numericGrade >= 80)
                    Console.WriteLine("Letter Grade: B");
                else if (numericGrade >= 70)
                    Console.WriteLine("Letter Grade: C");
                else if (numericGrade >= 60)
                    Console.WriteLine("Letter Grade: D");
                else
                    Console.WriteLine("Letter Grade: F");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            Console.WriteLine("Enter Integer Day(1-7):");
            int integerDay = Convert.ToInt32(Console.ReadLine());

            switch (integerDay)
            {
                case 1:
                    Console.WriteLine("Day: Monday");
                    break;
                case 2:
                    Console.WriteLine("Day: Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Day: Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Day: Thursday");
                    break;
                case 5:
                    Console.WriteLine("Day: Friday");
                    break;
                case 6:
                    Console.WriteLine("Day: Saturday");
                    break;
                case 7:
                    Console.WriteLine("Day: Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
    }
}
            