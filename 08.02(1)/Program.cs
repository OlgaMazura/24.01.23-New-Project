Console.Clear();
//1 type
void Method1()
{
    Console.WriteLine("KR, Olga Mazura");
}
//Method1();

//2 type
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Text message");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;//инкримент увеличение на 1; тегкримент уменьшение на 1
    }
}
//Method21("Text", 4);
//Method21(count: 4, msg: "New text");

//3 type
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//4 type
string Method4(int count, string text)
{
    string result = string.Empty;//result будет пустой строкой
    // while (i < count)
    // {
    //     result = result + text;
    //     i++;
    // }
    // return result;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
// string res = Method4(10, "Europe");
// Console.WriteLine(res);
//Задача: вывод табл умножения на экран

for (int i = 2; i <= 10; i++)
{
    for (int k = 2; k <= 10; k++)
    {
        Console.WriteLine($"{i} * {k} = {i*k}");
    }
    Console.WriteLine();
}