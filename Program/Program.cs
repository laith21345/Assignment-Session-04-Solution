// بسم الله الرحمن الرحيم
// Assignment 04 Solution

using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Claims;
using System.Threading;
using System.Xml.Linq;
using System;

namespace Program
{
    internal class Program
    {
        static void Main()
        {

            #region Q1
            //1. Write a program that allows the user to insert an integer then print all numbers between
            //   1 to that number.
            //   Example
            //   Input: 5
            //   Output: 1, 2, 3, 4, 5

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i < number ; i++)
            //{
            //    Console.Write($"{i}, ");
            //}
            //Console.Write(number);
            #endregion


            #region Q2
            //2. Write a program that allows the user to insert an integer then
            //   print a multiplication table up to 12.
            //   Example
            //   Input: 5
            //   Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12 ; i++)
            //{
            //    Console.Write($"{number* i} ");
            //}

            #endregion


            #region Q3
            //3. Write a program that allows to user to insert number then print all even numbers
            //   between 1 to this number.
            //   Example:
            //   Input: 15
            //   Output: 2 4 6 8 10 12 14

            #endregion


            #region Q4

            //4. Write a program that takes two integers then prints the power.
            //   Example:
            //   Input: 4 3
            //   Output: 64
            //   Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64

            #endregion


            #region Q5
            //5. Write a program to enter marks of five subjects and calculate total, average and percentage.
            //   Example
            //   Input: Enter Marks of five subjects: 95 76 58 90 89
            //   Output: Total marks = 408
            //           Average Marks = 81
            //           Percentage = 81

            #endregion


            #region Q6
            //6. Write a program to allow the user to enter a string and print the REVERSE of it.

            #endregion


            #region Q7

            //7. Write a program to allow the user to enter int and print the REVERSED of it.

            #endregion


            #region Q8

            //8. Write a program in C# Sharp to find prime numbers within a range of numbers.
            //   Test Data:
            //      Input starting number of ranges: 1
            //      Input ending number of range: 50
            //   Expected Output :
            //   The prime number between 1 and 50 are:
            //      2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

            #endregion


            #region Q9

            //9. Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //   Test Data:
            //      Enter a number to convert: 25
            //   Expected Output :The Binary of 25 is 11001.

            #endregion


            #region Q10

            //10. Create a program that asks the user to input three points(x1, y1), (x2, y2), and(x3, y3),
            //    and determines whether these points lie on a single straight line.

            #endregion


            #region Q11
            //11. Write a program that prints an identity matrix using for loop, in other words takes
            //    a value n from the user and shows the identity table of size n * n.

            #endregion


            #region Q12
            //12. Write a program in C# Sharp to find the sum of all elements of the array.

            #endregion


            #region Q13
            //13. Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            #endregion


            #region Q14
            //14. Write a program in C# Sharp to count the frequency of each element of an array.

            #endregion


            #region Q15
            //15. Write a program in C# Sharp to find maximum and minimum element in an array.

            #endregion


            #region Q16
            //16. Write a program in C# Sharp to find the second largest element in an array.

            #endregion


            #region Q17
            //17. Consider an Array of Integer values with size N, having values as
            //    in this Example
            //    7      0    0   0   0   5   6   7   5   0   7   5   3
            //  write a program find the longest distance between Two equal cells.In this example.
            //  The distance is measured by the number Of cells - for example, the distance between
            //  the first and the fourth cell is 2(cell 2 and cell 3).
            //
            //  In the example above, the longest distance is between the first 7 and the
            //  10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            //  And the 10th 7s.
            //
            //Note:
            //** Array values will be taken from the user
            //** If you have input like 1111111 then the distance is the number of
            //   Cells between the first and the last cell.

            #endregion


            #region Q18
            //18. Given a list of space separated words, reverse the order of the words.
            //
            //Input: this is a test     Output: test a is this
            //Input: all your base      Output: base your all
            //Input: Word               Output: Word
            //
            //Note : Check the Split Function(Member in String Class) Output will be a Single
            //       Console.WriteLine Statement.

            #endregion


            #region Q19
            //19. Write a program to create two multidimensional arrays of same size.Accept value from
            //    user and store them in first array.Now copy all the elements of first array
            //    on second array and print second array.

            #endregion


            #region Q20
            //20. Write a Program to Print One Dimensional Array in Reverse Order

            #endregion





            #region MyRegion

            //11. Write a program that prints an identity matrix using for loop, in other words takes
            //    a value n from the user and shows the identity table of size n * n.

            //12. Write a program in C# Sharp to find the sum of all elements of the array.

            //13. Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //14. Write a program in C# Sharp to count the frequency of each element of an array.

            //15. Write a program in C# Sharp to find maximum and minimum element in an array.

            //16. Write a program in C# Sharp to find the second largest element in an array.

            //17. Consider an Array of Integer values with size N, having values as
            //    in this Example
            //    7      0    0   0   0   5   6   7   5   0   7   5   3
            //  write a program find the longest distance between Two equal cells.In this example.
            //  The distance is measured by the number Of cells - for example, the distance between
            //  the first and the fourth cell is 2(cell 2 and cell 3).
            //
            //  In the example above, the longest distance is between the first 7 and the
            //  10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            //  And the 10th 7s.
            //
            //Note:
            //** Array values will be taken from the user
            //** If you have input like 1111111 then the distance is the number of
            //   Cells between the first and the last cell.

            //18. Given a list of space separated words, reverse the order of the words.
            //
            //Input: this is a test     Output: test a is this
            //Input: all your base      Output: base your all
            //Input: Word               Output: Word
            //
            //Note : Check the Split Function(Member in String Class) Output will be a Single
            //       Console.WriteLine Statement.

            //19. Write a program to create two multidimensional arrays of same size.Accept value from
            //    user and store them in first array.Now copy all the elements of first array
            //    on second array and print second array.


            //20. Write a Program to Print One Dimensional Array in Reverse Order

            #endregion



        }
    }
}
