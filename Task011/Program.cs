﻿/* Напишите прграмму, которая выводит случайное трёхзначное число,
и удаляет вторую цифру из этого числа. */


int n = new Random().Next(100, 1000);

int l = n / 100;
int r = n % 10;

Console.WriteLine($"{n} -> {l}{r}");

