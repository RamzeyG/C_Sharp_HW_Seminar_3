// 2. Напишите программу, которая принимает на вход координаты
//    двух точек и находит расстояние между ними в 3D пространстве.
//    https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/


void Func(){
    double[] array = {0, 0, 0, 0, 0, 0};
    int size = 6;
    int count = 0;

    while (count < size){
        int random = new Random().Next(-100,100);
        double n = Convert.ToDouble(random);
        array[count] = n;
        count++;
    }
    

    double answer = Math.Round(Math.Sqrt(Math.Pow((array[0]-array[1]), 2) + Math.Pow((array[2]-array[3]), 2) + Math.Pow((array[4]-array[5]), 2)), 4);

    Console.WriteLine($"Расстояние между точкой A({array[0]}, {array[1]}, {array[2]}) и точкой B({array[3]}, {array[4]}, {array[5]}) равно: {answer}");
}


Func();
Func();
Func();
