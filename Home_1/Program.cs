// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

string Numbers(int num1, int num2)
{
    // int result = 0;
    if(num1 < num2) return $"{num1} " + Numbers(num1 + 1, num2);
    else return  $"{num2}";
}

Console.WriteLine("Введите превое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(Numbers(m, n));