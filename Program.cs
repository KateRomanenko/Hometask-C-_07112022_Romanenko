
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/* Console.Clear();
Console.Write("Введите число 1: ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int numB = int.Parse(Console.ReadLine());

int result = 1;

for (int i = 1; i <= numB; i++)
{
    result *= numA;
}

Console.WriteLine(result);
*/

// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int result = 0;

while (number > 0)
{
    result += number % 10;
    number /=10;
}

Console.WriteLine(+result);
*/

// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

 void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
   while (index < length)
    {
        collection [index] = new Random().Next(9);
        index++;
    }
}
int [] mass = new int [8];
FillArray(mass);
Console.WriteLine(mass);

for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
}

