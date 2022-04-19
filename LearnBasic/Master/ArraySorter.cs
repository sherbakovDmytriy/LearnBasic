﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnBasic.Master
{
    internal class ArraySorter
    {

        /*
         * Пример работы
         * https://media.tproger.ru/uploads/2017/09/BubbleSort.gif
         */
        public static int[] BubbleSort(int[] array)
        {
            // Цикл прохда по массиву от второго до последнего элемента
            for (int i = 1; i < array.Length; i++)
            {
                /*
                 * Цикл прохода по массиву от первого до последнего неупорядоченного
                 * При i = 1 после прохода самое большое число оказывается в конце массива
                 * Таким образом мы знаем что последний символ создает упорядоченную часть массива
                 * При i = 2 после прохода второе самое большое занимает предпоследнее место
                 * Таким образом после каждого прохода область упорядоченного массива становится больше на 1
                 * Получается длинна этой области равна i
                 * Потому когда i == array.Length это значит что массив отсортирован
                 */
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }

            return array;
        }

        /*
         * Пример работы
         * https://media.tproger.ru/uploads/2017/09/InsertionSort.gif
         */
        public static int[] InsertionSort(int[] array)
        {
            // Цикл проходит от первого до предпоследнего элемента 
            for(int i = 0; i < array.Length - 1; i++)
            {
                // Цикл проходит начиная со сравнения элемента с индексом i и следующего
                // Если єлемент меньше то их меняют местами и опять сравнивают идя в сторону начала массива
                // Когда элемент больше мы понимаем что переместили его на нужное место и переходим к следующему
                // Уходя в блок i++
                for (int j = i + 1; j != 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tmp;
                    }
                    else
                        break;
                }
            }

            return array;
        }

        public static void PrintArray(int[] array)
        {
            foreach (int num in array)
                Console.Write(num + " ");
        }
    }
}
