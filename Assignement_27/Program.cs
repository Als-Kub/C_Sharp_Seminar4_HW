/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
Ограничения:
- Должна быть отдельная функция, которая возвразает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода
*/

Console.Clear();
Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine()!);
int result = CalculationSum(number);
PrintSum(result);

int CalculationSum(int number)
{
    int numberLength = (int)(Math.Floor(Math.Log10(number) + 1));
    int result = 0;
    int n = 1;
    for (int i = 0; i < numberLength; i++)
    {
        result += number / n % 10;
        n *= 10;
    }
    return result;
}
void PrintSum(int result)
{
    Console.WriteLine($"Sum of digits in your number is equal to {result}");
}