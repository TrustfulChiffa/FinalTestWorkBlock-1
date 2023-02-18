string[] arrayAnySize = new string[6] {"q", "qw", "qwe", "qwerty", "geek", "xyz"};
string[] arraySizeOf3 = new string[arrayAnySize.Length];

void SelectLinesLess4(string[] arrayAnySize, string[] arraySizeOf3)
{
    int count = 0;
    for (int i = 0; i < arrayAnySize.Length; i++)
    {
    if(arrayAnySize[i].Length <= 3)
        {
        arraySizeOf3[count] = arrayAnySize[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
