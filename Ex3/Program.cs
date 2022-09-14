// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.

int[] myArray = new int[8];

for (int i = 0; i < myArray.Length; i++)
{
   Console.WriteLine("Введите элемент массива (i = {0}): ", i);
   myArray [i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Вывод массива" );
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}


        


