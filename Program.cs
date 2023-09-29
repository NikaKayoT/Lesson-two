//public class Answer
//{
//    static void CompareNumbers(int firstNumber, int secondNumber)
//    {
//        if (firstNumber < secondNumber)
//        {
//            Console.WriteLine($"Первое число {firstNumber} меньше чем второе число {secondNumber}");
//        }
//        if (firstNumber > secondNumber)
//        {
//            Console.WriteLine($"Первое число {firstNumber} больше чем второе число {secondNumber}");
//        }
//        if (firstNumber == secondNumber)
//        {
//            Console.WriteLine($"Введенные числа равны {firstNumber}");
//        }
//    }
//    static public void Main(string[] args)
//    {
//        int firstNumber, secondNumber;
//        if (args.Length >= 2)
//        {
//            firstNumber = int.Parse(args[0]);
//            secondNumber = int.Parse(args[1]);
//        }
//        else
//        {
//            firstNumber = 9;
//            secondNumber = 4;
//        }
//        CompareNumbers(firstNumber, secondNumber);
//        Console.ReadKey();
//    }
//}




//public class Answer
//{
//    static int FindMax (int a, int b, int c)
//    {
//        int max = a;
//        if (max < b)
//        {
//            max = b;
//        }
//        if (max < c)
//        {
//            max = c;
//        }
//        return max;
//    }
//    static public void Main(string[] args)
//    {
//        int a, b, c;
//        if (args.Length >= 3)
//        {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//        }
//        else
//        {
//            a = 100;
//            b = 87;
//            c = 0;
//        }
//        int num = FindMax(a, b, c);
//        System.Console.WriteLine($"{num}");
//        Console.ReadKey();
//    }
//}



//class Answer
//{
//    static void CheckIfEven(int res)
//    {
//        if (res % 2 == 0)
//        {
//            Console.WriteLine($"Число {res} чётное");
//        }
//        if (res % 2 != 0)
//        {
//            Console.WriteLine($"Число {res} нечётное");
//        }
//    }
//    static public void Main(string[] args)
//    {
//        int res;
//        if (args.Length >= 1)
//        {
//            res = int.Parse(args[0]);
//        }
//        else
//        {
//            res = 7;
//        }
//        CheckIfEven(res);
//        Console.ReadKey();
//    }
//}



//public class Answer
//{
//    static void PrintEvenNumbers(int res)
//    {
//        for (int i = 1;  i <= res; i++)
//        {
//            if (i % 2 == 0)
//            {
//                Console.Write($"{i}\t");
//            }
//        }
//    }
//    static public void Main(string[] args)
//    {
//        int res;
//        if (args.Length >= 1)
//        {
//            res = int.Parse(args[0]);
//        }
//        else
//        {
//            res = 6;
//        }
//        PrintEvenNumbers(res);
//        Console.ReadKey();
//    }
//}


// Дни недели
//var res = Convert.ToInt32(Console.ReadLine());
//int[] workday = { 1, 2, 3, 4, 5 };
//int[] weekend = { 6, 7 };
//int indexOne = Array.IndexOf(weekend, res);
//if (indexOne != -1)
//{
//    Console.WriteLine("Да");
//}
//int indexTwo = Array.IndexOf(workday, res);
//if (indexTwo != -1)
//{
//    Console.WriteLine("Нет");
//}
//Console.ReadKey();



//Вторая цифра трёхзначного числа
//var res = Convert.ToInt32(Console.ReadLine());
//int num = res / 10 % 10;
//Console.WriteLine(num);



//Третья цифра есть или нет
//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num < 0)
//{
//    num *= -1;
//}
//while (num > 999)
//{
//    num /= 10;
//}      
//if (num < 100)
//{
//    Console.WriteLine("Третьей цифры нет");
//}
//else Console.WriteLine(num % 10);
//Console.ReadKey();






//public class Answer
//{
//    static void CompareNumbers(int firstNumber, int secondNumber)
//    {
//        if (firstNumber > secondNumber)
//        {
//            Console.WriteLine($"Первое число {firstNumber} больше чем второе число {secondNumber}");
//        }
//        else if (firstNumber < secondNumber)
//        {
//            Console.WriteLine($"Первое число {firstNumber} меньше чем второе число {secondNumber}");
//        }
//        else
//        {
//            Console.WriteLine($"Введенные числа равны {firstNumber}");
//        }
//    }
//    static public void Main(string[] args)
//    {
//        int firstNumber, secondNumber;
//        if (args.Length >= 2)
//        {
//            firstNumber = int.Parse(args[0]);
//            secondNumber = int.Parse(args[1]);
//        }
//        else
//        {
//            firstNumber = 4;
//            secondNumber = 4;
//        }
//        CompareNumbers(firstNumber, secondNumber);
//        Console.ReadKey();
//    }
//}