// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.WriteLine("Введите натуральное число А: ");
// int a=int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите натуральное число B: ");
// int b=int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Число {a} в степени {b}: {Stepen(a,b)}");

// //Возведение в натуральную степень
// int Stepen(int a,int b){
//     int rez=1;
//     if(b>0){
//     for(int i=1; i<=b; i++){
//     rez=rez*a;
//     }
//     }
//     return  rez;
// }

//Задача 27:Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("Введите число: ");
// int num27=int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр числа {num27}: {SumNumbers(num27)}");
// //Сумма цифр в числе
// int SumNumbers(int num){
//     int sum=0;
//     while(num>0){
//         sum+=num%10;
//         num=num/10;
//     }
//     return sum;
// }

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Write($"[{String.Join(",", RandomArray(8))}]");
//Заполнение массивыа случайными числами
int[] RandomArray(int size){
    int[] arr=new int[size];
    for(int i=0; i<size;i++){
        arr[i]=new Random().Next(0,1001);
    }
    return arr;
}