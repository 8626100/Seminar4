//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//(вводим массив с клавиатуры (т. е. через консоль :) ))
int n = 8;
int [] array = new int [n];
int i = 0;
while (i<n)
{
     Console.Write($"Введите {i}-й элемент массива ");
     array [i] = Convert.ToInt32(Console.ReadLine());
     i++;
}
Console.WriteLine(string.Join(",",array));
