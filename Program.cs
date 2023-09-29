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
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num *= -1;
}
while (num > 999)
{
    num /= 10;
}
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else Console.WriteLine(num % 10);
Console.ReadKey();