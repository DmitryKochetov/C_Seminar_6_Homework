/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3 */

Console.Clear();
Console.WriteLine("Введите числа, а я посчитаю, сколько из них положительных. Сколько чисел будем вводить?: ");
int maxIndex = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArrayDouble(maxIndex);
PrintArray(array);
Console.Write($" -> {GiveMePositiveCount(array)}");

int GiveMePositiveCount(double[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

double[] CreateArrayDouble(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите число {i+1}: ");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i] + "]");
    }
}