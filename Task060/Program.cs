﻿/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/




int[,,] massive = new int[5, 5, 5];         // Мне стало интересно, и я посмотрел на разные размеры массива
                                            // Вот только неповторяющимися числа не смог сделать, а время поджимает
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        for (int k = 0; k < massive.GetLength(2); k++)
        {
            massive[i, j, k] = new Random().Next(100, 1000);
            Console.Write($"{massive[i, j, k]} ({i}, {j}, {k}) ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}






