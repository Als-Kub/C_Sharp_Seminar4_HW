/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Ограничения:
- Нельзя использовать класс Math
- Должна быть отдельная функция Power, которая возвразает результат
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода
*/
Console.Clear();
Console.WriteLine("Enter number A");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number B");
int numberB = int.Parse(Console.ReadLine()!);
int result = CalculationPower(numberA, numberB);
PrintPower(result);

int CalculationPower(int numberA, int numberB)
{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result *= numberA;
    }
    return result;
}
void PrintPower(int result)
{
    Console.WriteLine($"A power B is equal to {result}");
}
