﻿int horas, minutos, N, segundos;

N = int.Parse(Console.ReadLine());

horas = N / 3600;
minutos = (N % 3600) / 60;
segundos = (N % 3600) % 60;

Console.WriteLine(horas + ":" + minutos + ":" + segundos);