
int findMin(int[] array)          // нахождение минимального элемента массива 
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

int findMax(int[] array)             // нахождение максимального элемента массива 
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return (max);
}

int findSum(int[] array)             // нахождение суммы элементов массива 
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum += array[i];
    return sum;
}

int FindProd(int[] array)           // нахождение произведения элементов массива
{
    int prod = 1;
    for (int i = 0; i < array.Length; i++)
        prod *= array[i];
    return prod;
}

void PrintArray(int[] array)   // вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

int Average(int[] array)       // среднее арифметическое элементов массива 
{
    int average = findSum(array) / array.Length;
    return average;
}

int countNegative(int[] array)        // колво отрицательных элементов в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            count++;
    }
    return count;
}

int count1(int[] array)        // подсчет колва вхождений элемента в массив
{
    Console.WriteLine("Введите значение: ");
    int x = int.Parse(Console.ReadLine() ?? "0");
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == x)
            count++;
    }
    return count;
}

int countEven(int[] array)           // количество четных элементов массива 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

int countPositive(int[] array)         // колво положительных элементов массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

int countOdd(int[] array)                  // колво нечетных элементов массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
            count++;
    }
    return count;
}

int Index(int[] array)   // Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1

{
    Console.WriteLine("Введите элемент: ");
    int number = int.Parse(Console.ReadLine() ?? "0");
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
            return i;
    }
    return -1;
}

bool Method(int[] array)                  // проверка, присутствует ли заданное число в массиве.
{
    Console.WriteLine("Введите число: ");
    int x = int.Parse(Console.ReadLine() ?? "0");
    bool element = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == x)
        {
            element = true;
            return element;
        }
        else
            element = false;
    }
    return element;
}

bool Method2(int[] array)             // проверка, является ли массив отсортированным по возрастанию.
{
    bool element = false;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[i - 1])
            element = true;
        else
        {
            element = false;
            return element;
        }
    }
    return element;
}
