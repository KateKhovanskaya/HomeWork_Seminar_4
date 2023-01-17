// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите натуральное число А: ");
int a=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите натуральное число B: ");
int b=int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {a} в степени {b}: {Stepen(a,b)}");

//Возведение в натуральную степень
int Stepen(int a,int b){
    int rez=1;
    if(b>0){
    for(int i=1; i<=b; i++){
    rez=rez*a;
    }
    }
    return  rez;
}