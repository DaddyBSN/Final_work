void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество элементов массива: ");
int amount = Convert.ToInt32(Console.ReadLine());
string[] arrList = new string[amount];
string[] arrTotal = new string[amount];
int length = 3;
int count = 0;

for (int i = 0; i < amount; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент: ");
    string text = Console.ReadLine()!;
    arrList[i] = text;
}

for (int i = 0; i < amount; i++)
{
    if (arrList[i].Length <= length)
    {
        arrTotal[count] = arrList[i];
        count++;
    }
}

Console.WriteLine();
PrintArray(arrTotal);
