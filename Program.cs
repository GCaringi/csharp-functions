void stampaArray(int[] array)
{
    Console.Write("[ ");
    foreach(int elem in array)
    {
        Console.Write($"{elem} ");
    }
    Console.Write(']');
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


int[] localArray = new[] { 2, 6, 7, 5, 3, 9 };

Console.WriteLine("Stampo l'array");
stampaArray(localArray);

Console.WriteLine("\nStampo l'array con gli elementi elevati al quadrato");
int[] powArray = powElemArray(localArray);
stampaArray(powArray);

Console.WriteLine("\nVerifico se l'array originale non sia stato modificato");
stampaArray(localArray);

Console.WriteLine("\nStampo la somma di tutti i numeri dell'array originale");
Console.WriteLine(totalSumArray(localArray));

Console.WriteLine("Stampo la somma di tutti i numeri dell'array con elementi al quadrato");
Console.WriteLine(totalSumArray(powArray));

//BONUS

int[] arrayFromUser(int size)
{
    int[] tmpArray = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Inserisci un numero: ");
        int tmpNum = Convert.ToInt32(Console.ReadLine());
        tmpArray[i] = tmpNum;
        Console.WriteLine();
    }

    return tmpArray;
}

Console.WriteLine("Bonus");
Console.WriteLine();
Console.Write("Quanti numeri vuoi inserire: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] userArray = arrayFromUser(size);

Console.WriteLine("Stampo l'array");
stampaArray(userArray);

Console.WriteLine("\nStampo l'array con gli elementi elevati al quadrato");
int[] userPowArray = powElemArray(userArray);
stampaArray(userPowArray);

Console.WriteLine("\nVerifico se l'array originale non sia stato modificato");
stampaArray(userArray);

Console.WriteLine("\nStampo la somma di tutti i numeri dell'array originale");
Console.WriteLine(totalSumArray(userArray));

Console.WriteLine("Stampo la somma di tutti i numeri dell'array con elementi al quadrato");
Console.WriteLine(totalSumArray(userPowArray));

