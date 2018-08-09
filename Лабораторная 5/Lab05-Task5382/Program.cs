﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// Пользователь вводит координаты точки x и y.
/// Программа проверяет, принадлежит ли эта точка закрашенной области.
/// Изображение областей можно найти по адресу:
/// ${папка с заданиями}/images/Области 4.png
/// 
/// В исходном коде решения намеренно допущена логическая ошибка.
/// 
/// Чтобы выполнить задание, нужно:
/// - Подобрать исходные данные для проверки задачи.
/// - Выяснить в каком случае программа работает неверно.
/// - Оформить отчет о тестировании.
/// 
/// Исправлять ошибку не нужно.
/// 
/// </summary>

// ОТЧЕТ О ТЕСТИРОВАНИИ
// В программе присутствует ограничения:
// 1) 2<y<4
// 2) x>1
// Эти ограничения образуют  области.
// Результаты проверки:
// Точки внутри областей.
// (2;3) -верно
// Точки на границах.
// (2;4) -верно
// (2;2) -верно
// (1;3) -верно
// Точки на пересечении границ.
// (1;4) -верно
// (1;2) -верно

namespace Lab05_Task5382
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y:");
            double y = double.Parse(Console.ReadLine());
            if (2 <= y)
            {
                if (x >= 1)
                {
                    Console.WriteLine("Принадлежит");
                }
                else {
                    Console.WriteLine("Не принадлежит");
                }
            }
            else {
                if (y <= 4)
                {
                    Console.WriteLine("Принадлежит");
                }
                else {
                    Console.WriteLine("Не принадлежит");
                }
            }
        }
    }
}
