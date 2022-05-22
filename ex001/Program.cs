// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int a = 1234;
int b = a;
int count = 1;

void Palindrom(int a)
{
    while (a > 10)
    {
        a = a / 10;
        count++;
        //Console.WriteLine(a);
    }
    //Console.WriteLine(count);

    int first = 0;
    int last = count;

    int y = b / Convert.ToInt32(Math.Pow(10, count - 1)) % 10;
    //Console.WriteLine($"Число count {y} ");
    int x = b / Convert.ToInt32(Math.Pow(10, first)) % 10;
    //Console.WriteLine($"Число first {x} ");

    while (count >= 1)
    {
        if (y == x)
        {
            first++;
            count--;
        }
        else
        {
            Console.WriteLine($"Число {b} не палиндром");
            break;
        }

    }
    if (count == 0)
    {
        Console.WriteLine($"Число {b} это палиндром!");
    }
}


Palindrom(a);

