//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNumber(int number)
{
    int count = Convert.ToString(number).Length;
    int advance = 0;
    int sum = 0;

    for (int i = 0; i < count; i++)
    {
        advance = number - number % 10;
        sum = sum + (number - advance);
        number = number / 10;
    }
    return sum;
}

Console.Write("Imput A: ");
int number = int.Parse(Console.ReadLine());

int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);


