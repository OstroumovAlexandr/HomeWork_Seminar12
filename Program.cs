// Задача 64: **Выполнить с помощью рекурсии**. Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNumbers(N,1));

// // ------Метод------------------------
// string PrintNumbers(int start, int end){
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start - 1, end));
// }



// Задача 66: **Выполнить с помощью рекурсии**.Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите значение M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintSumNumbers(M,N));

// //----------метод---------
// int PrintSumNumbers(int start, int end){
//     if(start == end)return 0;
//     int sum = 0;
//     for(int i = start; i <= end; i ++){
//         sum += i;
//     }
//     return sum;
// }





// Задача 68: **Выполнить с помощью рекурсии**.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите значение M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Ack(M,N));

// //----------метод---------
// int Ack(int start, int end){
//     if(start == 0)return end +1;
//     if(end == 0) return Ack(start-1, 1);
//     else{
//     return Ack(start -1, Ack (start,end -1));
// }
// }


