using System;
using System.Collections.Generic;
using System.Text;

namespace dataStruct
{
    public class ArrList : IFunctions
    {
        public ArrList()
        {
        }
        public int[] CreateArr(int length)
        {
            int[] arr = new int[length];
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 10);
            }
            return arr;
        } // completed
        public void AddAppend(int[] arr)
        {
            throw new NotImplementedException();
        }

        public void AddIndxItem(int[] arr)
        {
            throw new NotImplementedException();
        }

        public void ChangeHalfs(int[] arr)
        {
            throw new NotImplementedException();
        }

        public void ChangePlaces(int[] arr)
        {
            throw new NotImplementedException();
        }

        public void ChooseSort(int[] arr)
        {
            throw new NotImplementedException();
        }

        public int[] Concut(int[] arr)
        {
            Random rnd = new Random();
            Console.Write("Введите длинну 2-го массива: ");
            int e = Convert.ToInt32(Console.ReadLine());
            int[] addArr = new int[e];
            int[] fullArr = new int[addArr.Length + arr.Length];
            int startIndx = 0, index = 0;

            Console.WriteLine("Второй массив:");
            // заполняем второй массив
            for (int i=0; i<addArr.Length; i++)
            {
                addArr[i] = rnd.Next(1, 15);
                Console.Write(addArr[i] + " ");
            }
            // помещаем первый массив
            for (int i = 0; i < arr.Length; i++)
            {
                fullArr[i] = arr[i];
                startIndx = i;
            }
            // помещаем второй массив
            for (int j = startIndx + 1; j < arr.Length; j++)
            {
                fullArr[j] = arr[j];
            }
            Console.WriteLine("\nМассивы склеены!");
            return fullArr;
            
        } // создать массив сингл тоном

        public int[] DelItem(int[] arr)
        {
            int indx = Convert.ToInt32(Console.ReadLine());
            int[] tmpArr = new int[arr.Length];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == indx)
                    continue;
                else
                {
                    tmpArr[j] = arr[i];
                    j += 1;
                }
            }
            arr = tmpArr;
            Console.WriteLine("Элемент с индексом " + indx + " удален.");
            return arr;
        } // completed

        public void MaxIndx(int[] arr)
        {
            int max = arr[0];
            int indx=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    indx = i;
                }
            }
            Console.WriteLine("Индекс максимального элемента массива: " + indx);
        } // completed

        public void MaxItem(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Максимальный элемент массива: " + max);
        } // completed

        public void MinIndx(int[] arr)
        {
            int min = arr[0];
            int indx=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    indx = i;
                }
            }
            Console.WriteLine("Индекс минимального элемента массива: " + indx);
        } // completed

        public void MinItem(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Минимальный элемент массива: " + min);
        } // completed

        public void Shake(int[] arr)
        {
            Random rd = new Random();
            int randIndx, tmp, a = 0;
            while (a <= 29)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = arr.Length - 1 - i; j >= 0; j--)
                    {
                        randIndx = rd.Next(i, arr.Length - 1);
                        tmp = arr[j];
                        arr[j] = arr[randIndx];
                        arr[randIndx] = tmp;
                    }
                }
                a++;
            }
            Console.WriteLine("Массив перемешан!");
        } // completed

        public void Show(int[] arr)
        {
            Console.WriteLine("М а с с и в : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        } // completed

        public void SumItems(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Сумма всех элементов = " + sum);
        } // completed
        public void BubbleSort(int[] arr)
        {

        }
        public void InsertSort(int[] arr)
        {

        }
        public void SelectSort(int[] arr)
        {

        }
        public void ShellSort(int[] arr)
        {

        }
        public void MergeSort(int[] arr)
        {

        }
        public void HeapSort(int[] arr)
        {

        }
        public void QuickSort(int[] arr)
        {

        }
        public void Reverse(int[] arr)
        {

        }
    }
}
