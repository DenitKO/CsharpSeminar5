void FillArray (int [] collection)
{
    int LengthOfArr = collection.Length;
    int i = 0;
    while (i < LengthOfArr)
    {
        collection[i] = new Random().Next(100,1000);
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

int EvenNumbersOfArray(int[] EvenArray)
{
    int EvenNumbers = 0;
    int i = 0;
    int EvenAmount = EvenArray.Length;
        while (i < EvenAmount)
        {
            if (EvenArray[i] % 2 == 0)
                EvenNumbers++;
            i++;
        }
    return EvenNumbers;
}

int answer = EvenNumbersOfArray(array);

Console.Write("Из них четных ");

Console.Write(answer);