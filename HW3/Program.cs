void FillArray (int [] collection)
{
    int LengthOfArr = collection.Length;
    int i = 0;
    while (i < LengthOfArr)
    {
        collection[i] = new Random().Next(1,100);
        i++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]+" ");
        position++;
    }
    Console.WriteLine();
}

Console.Write("Введите количество ячеек массива ");

int amount = Convert.ToInt32(Console.ReadLine());

int[] array = new int[amount];

FillArray(array);

PrintArray(array);

int MaxCountArray (int [] SomeMaxArray)
{
    int Count = SomeMaxArray.Length;
    int index = 1;
    int MaxCount = SomeMaxArray[0];
    while (index < Count)
    {
        if (MaxCount < SomeMaxArray[index])
            MaxCount = SomeMaxArray[index];
        index++;
    }
    return MaxCount;
}

int MinCountArray (int [] SomeMinArray)
{
    int Count = SomeMinArray.Length;
    int MinIndex = 1;
    int MinCount = SomeMinArray[0];
    while (MinIndex < Count)
    {
        if (MinCount > SomeMinArray[MinIndex])
            MinCount = SomeMinArray[MinIndex];
        MinIndex++;
    }
    return MinCount;
}

int MaxDigit = MaxCountArray(array);

int MinDigit = MinCountArray(array);

Console.Write("Разница между максимальным и минимальным эллементом массива = ");
Console.WriteLine(MaxDigit-MinDigit);