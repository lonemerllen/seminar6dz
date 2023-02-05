// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите кол-во:");
int M = int.Parse(Console.ReadLine()!);
int[] a = new int[M];
int res=0;
for (int i=0;i<M; i++){
    a[i] = int.Parse(Console.ReadLine()!);
    if (a[i]>0) res+=1;
}
Console.WriteLine($"{res} чисел - больше 0");