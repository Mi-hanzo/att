﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] original = ["efew", "ff", "23f4", "4ga", "rew", "fdfd2", "jlo", "tyzs"];
string[] filter = new string[original.Length];
int i2 = 0;

void CreateFilter()
{
    for (int i = 0; i < original.Length; i++)
    {
        if (original[i].Length <= 3)
        {
            filter[i2] = original[i];
            i2++;
        }
    }
}

void PrintFilter()
{
    for (int i = 0; i < filter.Length; i++)
    {
        System.Console.Write(filter[i] + " ");
    }
}

CreateFilter();
PrintFilter();