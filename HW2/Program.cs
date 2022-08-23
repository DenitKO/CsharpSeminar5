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

int SumOfOddArray (int[] ArrayForOdd)
{
    int LengthOfOdd = ArrayForOdd.Length;
    int SumOfOdd = 0;
    int i = 0;
    while (i < LengthOfOdd)
    {
        if (!(ArrayForOdd[i]%2 == 0))
            SumOfOdd = SumOfOdd + ArrayForOdd[i];
        i++;
    }
    return SumOfOdd;
}

int answer = SumOfOddArray(array);

if (answer == 0)
Console.Write("Нечётные эллементы массива отсутвуют");
else
{
    Console.Write("Сумма нечетных эллементов массива равна = ");
    Console.WriteLine(answer);
}