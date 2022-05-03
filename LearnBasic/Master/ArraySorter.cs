namespace LearnBasic.Master
{
    public class ArraySorter
    {

        public int[] array;

        public ArraySorter(int length)
        {
            array = new int[length];
        }

        public void FillByRandom()
        {
            Random randNum = new();
            for (int i = 0; i < array.Length; i++)
                array[i] = randNum.Next(1, 100);
        }

        /*
         * Пример работы
         * https://media.tproger.ru/uploads/2017/09/BubbleSort.gif
         */
        public void BubbleSort()
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
                        Swap(j, j + 1);
                }
            }
        }

        /*
         * Пример работы
         * https://media.tproger.ru/uploads/2017/09/InsertionSort.gif
         */
        public void InsertionSort()
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
                        Swap(j, j - 1);
                    else
                        break;
                }
            }
        }

        public void SelectionSort()
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[minIndex] > array[j])
                        minIndex = j;
                }

                Swap(minIndex, i);
            }
        }

        public void ShellSort(int delta)
        {
            while(delta != 0)
            {
                for(int i = delta; i < array.Length; i++)
                {
                    int prevIndex = i - delta;
                    int currentIndex = i;

                    while (prevIndex >= 0)
                    {
                        if (array[currentIndex] < array[prevIndex])
                        {
                            Swap(currentIndex, prevIndex);
                            currentIndex = prevIndex;
                            prevIndex -= delta;
                        }
                        else
                            break;
                    }
                }

                delta--;
            }
        }

        public void PrintArray()
        {
            foreach (int num in array)
                Console.Write(num + " ");
        }

        private void Swap(int index1, int index2)
        {
            int tmp = array[index1];
            array[index1] = array[index2];
            array[index2] = tmp;
        }
    }
}
