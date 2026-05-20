//WorkWithIntegers();
OrderPrecedence();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);


    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
double a = 10;
double b = 19;
double c = 25;
double d = (a + b) / c;
Console.WriteLine(d);
}

void WorkWithDoubles()
{
double a = 1000;
double b = 50;
double c = 2567;
double d = (a + b) / c;
Console.WriteLine(d);
}