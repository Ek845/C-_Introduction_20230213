﻿// 24. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем Х и У не 0.

double X=2.5;
double Y=-8;

if (X>0 && Y>0) System.Console.WriteLine($"Точка с координатами ({X}:{Y}) находится в 1-ой четверти плоскости");
if (X<0 && Y>0) System.Console.WriteLine($"Точка с координатами ({X}:{Y}) находится во 2-ой четверти плоскости");
if (X<0 && Y<0) System.Console.WriteLine($"Точка с координатами ({X}:{Y}) находится в 3-ей четверти плоскости");
if (X>0 && Y<0) System.Console.WriteLine($"Точка с координатами ({X}:{Y}) находится в 4-ой четверти плоскости");