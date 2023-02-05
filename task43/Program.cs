// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =
// 9 -> (-0,5; -0,5)
Console.Clear();
double b1 = 14.0;
double k1 = 5.0;
double b2 = 6.0;
double k2 = 10.0;
if (k1==k2){
    Console.WriteLine("Прямые параллельны");
}
else{
    double x=(b2-b1)/(k1-k2);
    double y=k1*x+b1;
    Console.WriteLine($"({x};{y})");
}
