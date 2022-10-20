// функция, которая вычисляет число a в степени n

double stepen(int a, int n)
{
    double x = Math.Pow(a, n);
    return x;
}

// вычисление факториала числа 

int factorial(int n)
{
    int product = 1;
    while (n > 0)
    {
        product *= n;
        n--;
    }
    return product;
}

// Функция, которая вычисляет сумму цифр произвольного целого числа n

int sumNumbers(int n)
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

int SumNumbers (int a, int b)
{
    int c = a+ b;
    return c;
}

// Функция, определяющая вляется ли число простым, то есть возвращающую true, если число простое, иначе - false

bool Method(int n)
{
    if (n % 1 == 0 && n % n == 0 && n % (n / 2) == 1)
        return true;
    else
        return false;
}

// Функция, определяющая является ли число чётным, то есть возвращающую true, если число чётное, иначе - false

bool Method2(int n)
{
    if (n % 2 == 0)
        return true;
    else
        return false;
}