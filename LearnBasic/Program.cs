//Console.WriteLine("Insert your answer here please:");
//string a = Console.ReadLine();
//Console.Write(a);
//bool b = false;
//Console.WriteLine($"\nРаботает:{b}");
using LearnBasic.Master;
using System;

#region Samples2L
//namespace Learn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Insert your answer here please:");
//            string a = Console.ReadLine();
//            Console.WriteLine(a);
//            bool b = false;
//            Console.WriteLine($"Работает:{b}");

//        }
//    }
//}
//Console.Write("Insert your number");
//long b = Convert.ToInt64(Console.ReadLine());
//int num2 = Convert.ToInt32(b);
//Console.WriteLine($"your solution 1={num2}");    // num2

//Console.Write("Insert your number");
//int c = Convert.ToInt32(Console.ReadLine());
//short num4 = Convert.ToInt16(c);
//Console.WriteLine($"your solution 2={num4}");    //num4
//Console.Write($"Your result = {num2 - num4}");

//Console.Write("Insert your number 1");
//double num1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Insert your number 2");
//double num2 = Convert.ToDouble(Console.ReadLine());
//double b = num1 / num2;
//Console.WriteLine($"Your result of / = {Math.Round(b, 2)}");
//Console.WriteLine($"Your result of / = {b}");

//int a = 5;
//int b = 6;
//int c = a + b;
//Console.Write(c);

//double a = 6;
//double b = 10;
//double c = a / b;
//Console.Write(c);

//double x = 10.0;
//double z = x % 4.0;
//Console.WriteLine(z);

//int x1 = 5;
//int z1 = (++x1) + 1; // 7
//Console.WriteLine(z1 - x1); // 1

//int x2 = 5;
//int z2 = x2++; // 5
//Console.WriteLine(x2 - z2); // 1

//int x1 = 5;
//int z1 = --x1; // 4
//Console.WriteLine(x1 - z1); //0

//int x2 = 5;
//int z2 = x2--; // 5
//Console.WriteLine(x2 - z2); //-1

//int a = 3;
//int b = 5;
//int c = 40;
//int d = (c--) - (b * a);    // d=25
//Console.WriteLine(d);

//a = 3;
//b = 5;
//c = 40;
//d = (c - (--b)) * a;    // d=108
//Console.WriteLine(d);

// 101101
//1100110
//1001011

//int a = 5;
//Console.WriteLine(a&=2);

//try
//{
//    int a = 33;
//    int b = 600;
//    byte c = checked((byte)(a + b));
//    Console.WriteLine(c);
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine(ex.Message);
//}
#endregion

namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SAMPLE3
            //Console.Write("Please write down the number");
            //string a = Console.ReadLine();
            //if (a == "5" || a == "10")
            //{
            //    Console.WriteLine($"Число больше 5 и меньше 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Неизвестное число");
            //}   
            #endregion
            #region SampleL2
            //Console.Write("Please write down the number");
            //double b = Convert.ToDouble(Console.ReadLine());
            //if (a == b)
            //{
            //    Console.Write($"Solution {a}={b}");
            //}
            //else if (a > b)
            //{
            //    Console.Write($"Solution {a}>{b}");
            //}
            //else
            //{
            //    Console.Write($"Solution {a}<{b}");
            //}
            #endregion
            #region Sample 4
            //Console.WriteLine("Введите номер операции: \n 1.Сложение \n 2.Вычитание \n 3.Умножение");
            //int b = 3, c = 6;
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a == 1)
            //    Console.Write($"{b}+{c}={b+c}");
            //else if (a == 2)
            //    Console.Write($"{b}-{c}={b - c}");
            //else if (a == 3)
            //    Console.Write($"{b}*{c}={b * c}");
            //else
            //    Console.Write("other result");
            #endregion
            #region Sample Switch/Case
            //switch (a)
            //{
            //    case 1:
            //        Console.Write($"{b}+{c}={b + c}");
            //        break;
            //    case 2:
            //        Console.Write($"{b}-{c}={b - c}");
            //        break;
            //    case 3:
            //        Console.Write($"{b}*{c}={b * c}");
            //        break;
            //    default:
            //        Console.Write("other result");
            //        break;
            //}
            #endregion
            #region Homework 1
            //Console.Write("Insert the amount of your deposit here:");
            //double a = Convert.ToDouble(Console.ReadLine());
            //if (a < 100)
            //{
            //    Console.WriteLine($"Your final deposit amount will count: {(a * 0.05) + 15}");
            //}
            //else if (a <= 200 && a >= 100)
            //{
            //    Console.WriteLine($"Your final deposit amount will count: {(a * 0.07) + 15}");
            //}
            //else
            //{
            //    Console.WriteLine($"Your final deposit amount will count: {(a * 0.1) + 15}");
            //    #endregion
            //}
            #endregion
            #region Homework 2
            //Console.WriteLine("Введите номер операции: \n 1.Сложение \n 2.Вычитание \n 3.Умножение");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите 1 переменную: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите 2 переменную: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //if (a == 1)
            //    Console.Write($"{b}+{c}={b+c}");
            //else if (a == 2)
            //    Console.Write($"{b}-{c}={b - c}");
            //else if (a == 3)
            //    Console.Write($"{b}*{c}={b * c}");
            //else
            //    Console.Write("other result");
            #endregion
            #region Lektion3
            //Console.Write("Insert deposit:");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Write month:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //double c = a; // for memory field
            //for (int i = 0; i < b; i++)
            //{
            //    c *= 1.07;
            //}
            //Console.WriteLine($"Result:{Math.Round(c)}");
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write($"{i}*{j}={i * j}  ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region L3 home1
            //Console.Write("Insert deposit:");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Write month:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //double c = a;
            //int i = 0;
            //while (i <= b)
            //{
            //    c *= 1.07;
            //    i++;
            //}
            //Console.Write($"Result:{c}");
            #endregion

            #region hw2
            //bool res;
            //int a;
            //int b;
            //do
            //{
            //    Console.WriteLine("Insert 1 number:");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Insert 2 number:");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    res = a >= 0 && a <= 10;

            //    if (!res)
            //    {
            //        Console.WriteLine("Wrong number");
            //    }
            //}
            //while (!res);

            //Console.WriteLine($"Result:{a + b}");



            //for (; ;)
            //{
            //    Console.WriteLine("Insert 1 number:");
            //    double a = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Insert 2 number:");
            //    double b = Convert.ToDouble(Console.ReadLine());

            //    if (a >= 0 && a <= 10 && b >= 0 && b <= 10)
            //    {
            //        Console.WriteLine($"Result:{a}+{b}");
            //        break;
            //    }
            //    else
            //        Console.WriteLine($"Wrong bitch");

            //}
            #endregion
            #region hw
            //Console.WriteLine("Expected Output :");
            //string[] array = { "1", "T", "3", "M", "f", "6"};
            ////for (int i = 0; i < array.Length; i++)
            ////{
            ////    Console.W3rite($"{i} \t");
            ////}
            //foreach (string a in array)
            //{
            //    Console.WriteLine($"{a}");
            //}

            //Console.WriteLine("Insert number:");
            //int a = Convert.ToInt32(Console.ReadLine());
            ////int[] names = Enumerable.Range(0, 10).ToArray();
            ////var partNames = new ArraySegment<int>(names) as IList<int>;
            //int[] numbers = { 1, 2, 3, 4 };
            //var n = numbers.Length;

            //if (n < a)
            //    {
            //        Console.Write("Damn! Get your bets lower");
            //    }
            //else
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"{a + numbers[i]} \t");
            //    }
            //}
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //foreach (int number in numbers)
            //{
            //    Console.Write(number+"\t");
            //}
            //Console.WriteLine($"\n");
            //Console.WriteLine("Sum up:");
            //Console.WriteLine($"{numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] + numbers[5] + numbers[6]}");
            #endregion
            #region Lektion4
            //Random rnd = new Random();
            //int value = rnd.Next(1, 10);
            //Console.WriteLine(value);
            //int[] array = new int[value];

            //for (int i = 0; i< array.Length; i++)
            //{
            //    array[i] = rnd.Next();
            //    Console.Write($"{array[i]} ");

            //    if (i % 2 == 0)
            //    {
            //        array[i] = 2;
            //    }
            //    else
            //        array[i] = 1;
            //}
            //Console.WriteLine(" ");

            //foreach (int number in array)
            //{
            //    Console.WriteLine($"{number}");
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"{array[i]} ");
            //}
            #endregion

            //Random rnd = new Random();
            //int value = rnd.Next(1, 5);
            //Console.WriteLine(value);
            //int[] array = new int[value];

            //for (int i = 0; i < array.Length; i++)
            //{

            //    array[i] = rnd.Next();
            //    Console.Write(array[i]);
            //    Console.WriteLine(" ");
            //    Console.WriteLine($"AV result:{array[i] / value}");
            //}

            //Console.Write("Input number of terms:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //for(int i = 0; i <= a; i++)
            //{
            //    Console.WriteLine($"Number is : {i} and cube of the {i} is :{i*i*i} ");
            //}

            //Console.Write("Input the number(Table to be calculated):");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //do
            //{
            //    Console.WriteLine($" {a}X{i}={a*i}");
            //    i++;
            //}
            //while (a >= i);

            //Console.WriteLine("Input upto the table number starting from 1:");
            //int a = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1;i <= a; i++)
            //{
            //    for(int j = 1 ;j <= a;)
            //    {
            //        Console.WriteLine($"{i}*{j} = {i * j}");
            //        j++;
            //    }
            //}

            //Console.WriteLine($"Input number of terms:");
            //int customerNumber = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //int counter = 0;
            //for (int i = 0; counter <= customerNumber; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine($"{i}");
            //        result += i;
            //        counter++;
            //    }
            //    else
            //        Console.WriteLine($" ");
            //}           
            //Console.WriteLine($"Result:{result}");

            //int[][] arr = new int[3][];
            //arr[0] = new int[] { 1, 2 };
            //arr[1] = new int[] { 1, 2, 3 };
            //arr[2] = new int[] { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j]+" ");

            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Insert number u need:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= a; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            Start.Up();

        }
    }
}