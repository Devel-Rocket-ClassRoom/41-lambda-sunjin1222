using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

// README.md를 읽고 아래에 코드를 작성하세요.

int[] numbers = { 10, 25, 7, 42, 18, 33 };


int ProcessArray(int[] data, Func<int[], int> processor)
{
    return processor(data);
}

Func<int[],int> add= ProcessArray =>
{
    int sum = 0;
    for (int i = 0; i < ProcessArray.Length; i++)
    {
        sum += ProcessArray[i];
    }
    return sum;
};

Func<int[], int> max = ProcessArray =>
{
    int max = int.MinValue;
    for (int i = 0; i < ProcessArray.Length; i++)
    {
        if (max < ProcessArray[i])
        {
            max = ProcessArray[i];
        }
    }
    return max;
};

Func<int[], int> min = ProcessArray =>
{
    int min = int.MaxValue;
    for (int i = 0; i < ProcessArray.Length; i++)
    {
        if (min > ProcessArray[i])
        {
            min = ProcessArray[i];
        }
    }
    return min;
};

Func<int[], int> even = ProcessArray =>
{
    int even = 0;
    for (int i = 0; i < ProcessArray.Length; i++)
    {
        if (ProcessArray[i] % 2==0)
        {
            even++;
        }
    }
    return even;
};


Console.Write("배열: ");
foreach (int number in numbers)
{
    Console.Write($"{number}, ");
}
Console.WriteLine();
Console.WriteLine($"합계: {ProcessArray(numbers,add)}");
Console.WriteLine($"최댓값: {ProcessArray(numbers, max)}");
Console.WriteLine($"최솟값: {ProcessArray(numbers, min)}");
Console.WriteLine($"짝수 개수: {ProcessArray(numbers, even)}");




