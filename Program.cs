// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}

void notevenindex(int[] NewArray)
{
    int oddSum = 0;
    for (int i = 1; i < NewArray.Length; i=i+2) oddSum = oddSum + NewArray[i];
    Console.WriteLine($"The Sum of odd index numbers is {oddSum}");
}

Console.Write("Enter the massive size: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Enter the minimum massive number: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Enter the maximum massive number: ");
int max = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(size, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]");
notevenindex(Array);
