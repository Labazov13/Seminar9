/*Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

System.Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int SumNumbers(int num)
{
    if (num == 0)
    {
        return 0;
    }

    return (num % 10 + SumNumbers(num / 10));
}

System.Console.WriteLine(SumNumbers(N));

