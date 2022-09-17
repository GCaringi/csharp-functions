void stampaArray(int[] array)
{
    foreach(int elem in array)
    {
        Console.Write(elem);
    }
}

int pow (int num)
{
    return num * num;
}

int[] powElemArray(int[] array)
{
    int[] tmpArray = new int[array.Length];

    for (int i = 0; i < tmpArray.Length; i++)
    {
        tmpArray[i] = pow(array[i]);
    }

    return tmpArray;
}

int totalSumArray(int[] array)
{
    int sum = 0;
    foreach(int elem in array)
    {
        sum += elem;
    }
    
    return sum;
}

