using System;
using System.Collections.Generic;
using System.Text;

namespace dataStruct
{
    class AList : IMyList
    {
        int[] initialArray;
        public AList(int[] userArr)
        {
            this.initialArray = userArr;
        }
        public void FillArray() // заполнение массива
        {
            //Console.WriteLine("Заполненный массив:");
            Random rd = new Random();
            int indx;
            for (int i = 0; i < initialArray.Length; i++)
            {
                initialArray[i] = rd.Next(10, 100);
                //Console.Write(initialArray[i] + " ");
            }
            //Console.WriteLine();
        }

        public void ShowArray()
        {
            Console.WriteLine("М а с с и в : ");
            for (int i = 0; i < initialArray.Length; i++)
            {
                Console.Write(initialArray[i] + " ");
            }
            Console.WriteLine("\n");
        }

        public int[] CreateArr()
        {
            int[] arr = new int[initialArray.Length];
            Random rd = new Random();
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = rd.Next(1, 10);
            }
            return arr;
        }

        public void AddAppend(int value)
        {
            Console.WriteLine("\nДобавляем элемент...");
            int[] tmpArr = new int[initialArray.Length+1];
            for (int i = 0; i < initialArray.Length; i++)
            {
                tmpArr[i] = initialArray[i];
            }
            tmpArr[initialArray.Length] = value;
            Console.WriteLine("В конец массива добавлен элемент: " + value);
            initialArray = tmpArr;
        }

        public void AddIndx(int indx, int value)
        {
            int[] tmpArr = new int[initialArray.Length + 1];

            if (indx <= initialArray.Length)
            {
                for (int i = 0; i < indx; i++)
                {
                    tmpArr[i] = initialArray[i];
                }
                tmpArr[indx] = value;
                for (int j = indx + 1; j < tmpArr.Length; j++)
                {
                    tmpArr[j] = initialArray[j-1];
                }
                Console.WriteLine("\nЭлемент с индексом " + indx + " добавлен!");
            }
            else
            {
                Console.WriteLine("В массиве не существует такого индекса.");
            }
            initialArray = tmpArr;
        }

        public void BubbleSort()//
        {
            int tmp = 0;
            for (int i= initialArray.Length - 1; i>0; i--)
            {
                for (int j=0; j<i; j++)
                {
                    if (initialArray[j]>initialArray[j+1])
                    {
                        tmp = initialArray[j];
                        initialArray[j] = initialArray[j + 1];
                        initialArray[j + 1] = tmp;
                    }
                }
            }
            Console.WriteLine("Выполнена пузырьковая сортировка.");
        }

        public void ChangePlaces()//поменять местами половины массива
        {
            int[] tmpArr = new int[initialArray.Length];
            int indx = initialArray.Length / 2;
            for (int i = 0; i < initialArray.Length/2; i++)
            {
                tmpArr[i] = initialArray[indx];
                indx += 1;
            }
            indx = 0;
            for (int j = initialArray.Length / 2; j < tmpArr.Length; j++)
            {
                tmpArr[j] = initialArray[indx];
                indx += 1;
            }
            initialArray = tmpArr;
            Console.WriteLine("Массив перевернут.");

        }

        public void Concut(int[] arr)//склейка массивов
        {
            int[] addArr = new int[initialArray.Length + arr.Length];
            int startIndx = 0, index = 0;
            for (int i = 0; i < initialArray.Length; i++)
            {
                addArr[i] = initialArray[i];
                startIndx = i;
            }
            for (int j = 0; j < arr.Length; j++)
            {
                startIndx += 1;
                addArr[startIndx] = arr[j];
            }
            initialArray = addArr;
            Console.WriteLine("Массивы склеены!");
        }

        public void DelIndx(int indx)//del по индексу
        {
            Console.WriteLine("\nУдаление элемента...");
            int[] tmpArr = new int[initialArray.Length];
            int j = 0;
            for (int i=0; i<initialArray.Length; i++)
            {
                if (i == indx)
                    continue;
                else
                {
                    tmpArr[j] = initialArray[i];
                    j += 1;
                }
            }
            initialArray = tmpArr;
            Console.WriteLine("Элемент с индексом " + indx + " удален.");
        }

        public void HeapSort()//
        {
            throw new NotImplementedException();
        }

        public void InsertSort()//
        {
            throw new NotImplementedException();
        }

        public int MaxElems()//
        {
            int max = 0;
            for (int i=0; i<initialArray.Length; i++)
            {
                if (initialArray[i]>max)
                {
                    max = initialArray[i];
                }
            }
            return max;
        }

        public int MaxIndex()//
        {
            int indx = 0;
            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i] > initialArray[indx])
                {
                    indx = i;
                }
            }
            return indx;
        }

        public void MergeSort()//
        {
            throw new NotImplementedException();
        }

        public int MinElems()//
        {
            int min = initialArray[0];
            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i] < min)
                {
                    min = initialArray[i];
                }
            }
            return min;
        }

        public int MinIndex()//
        {
            int indx = 0;
            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i] < initialArray[indx])
                {
                    indx = i;
                }
            }
            return indx;
        }

        public void QuickSort()//
        {
            throw new NotImplementedException();
        }

        public void Reverse()//переворот массива
        {
            int[] tmpArr = new int[initialArray.Length];
            for (int j=0, i=initialArray.Length - 1; i>=0; i--)
            {
                tmpArr[j] = initialArray[i];
                j++;
            }
            initialArray = tmpArr;
            Console.WriteLine("Массив перевернут.");
        }

        public void SelectSort()//
        {
            int min, tmp;
            for (int i=0; i<initialArray.Length; i++)
            {
                min = initialArray[i];
                for (int j=i+1; j<initialArray.Length; j++)
                {
                    if (initialArray[j] < min)
                    {
                        min = initialArray[j];
                        tmp = initialArray[i];
                        initialArray[i] = min;
                        initialArray[j] = tmp;
                    }
                }
            }
            //Console.Write("minimun: " + min);

        }

        public void Shake()// перемешивание отсортированного массива
        {
            Random rd = new Random();
            int randIndx, tmp, a = 0;
            while (a<=30)
            {
                for (int i = 0; i < initialArray.Length; i++)
                {
                    for (int j = initialArray.Length-1-i; j>=0;  j--)
                    {
                        randIndx = rd.Next(i, initialArray.Length - 1);
                        tmp = initialArray[j];
                        initialArray[j] = initialArray[randIndx];
                        initialArray[randIndx] = tmp;
                    }
                }
                a++;
            }
        }

        public void ShellSort()//
        {
            throw new NotImplementedException();
        }

        public int SumElements()//сумма элементов массива
        {
            int sum=0;
            for (int i=0; i<initialArray.Length; i++)
            {
                sum += initialArray[i];
            }
            return sum;
        }   
    }
}
