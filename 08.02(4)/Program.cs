Console.Clear();
int[] A = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int Count = array.Length;

    for (int i = 0; i < Count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MaxPosition = i;
        for (int k = i + 1; k < array.Length; k++)
        {
            if (array[k] > array[MaxPosition]) MaxPosition = k;
        }
        int Temporary = array[i];
        array[i] = array[MaxPosition];
        array[MaxPosition] = Temporary;
    }
}

PrintArray(A);
SelectionSort(A);

PrintArray(A);
