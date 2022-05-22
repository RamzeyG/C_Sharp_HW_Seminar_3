// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void func(int b){
    int count = 1;
    while(count <= b){
        int x = count*count*count;
        Console.WriteLine($"{count}^3 = {x}");
        count ++;
    }
}

Console.WriteLine("Введите любое целое число");

string a = Console.ReadLine();
int b = int.Parse(a);


func(b);



//Console.WriteLine("Hello, World!");
