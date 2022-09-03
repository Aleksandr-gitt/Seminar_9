// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int sum = 0;
int Numbers(int num1, int num2)
{
    // int sum = 0;
    // for(int i = num1; i <= num2; i++) 
    // {
    //     sum = sum + i;
    // }
    if(num1 <= num2)
    {
        sum += num1;
        Numbers(num1 + 1, num2);
    } 
    return sum;
}

Console.WriteLine("Введите превое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(Numbers(m, n));