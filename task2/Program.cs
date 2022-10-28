// функция, которая вычисляет число a в степени n

double Stepen(int a, int n)
{
    double x = Math.Pow(a, n);
    return x;
}

// вычисление факториала числа 

int Factorial(int n)
{
    int prod = 1;
    while (n > 0)
    {
        prod *= n;
        n--;
    }
    return prod;
}

// Функция, которая вычисляет сумму цифр произвольного целого числа n

int SumNumbers(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

// Функция, складывающая два целых числа

int SumTwoNumbers(int a, int b)
{
    return a + b;
}

// Функция, определяющая вляется ли число простым, то есть возвращающую true, если число простое, иначе - false

bool IsNumberSimple(int n)
{
    if (n % 1 == 0 && n % n == 0 && n % (n / 2) == 1)
        return true;
    else
        return false;
}

// Функция, определяющая является ли число чётным, то есть возвращающую true, если число чётное, иначе - false

bool IsNumberEven(int n)
{
    if (n % 2 == 0)
        return true;
    else
        return false;
}
