using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dataStruct
{
    public class ArrList : IFunctions
    {
        public ArrList()
        {
        }
        MainArray mArr = new MainArray();
        public void CreateArr(int length)
        {
            int[] arr = new int[length];
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 10);
            }
            mArr.UpDate(arr);
        } // completed
        public void AddAppend()
        {
            int[] arr = mArr.GetArr();
            Console.WriteLine("Введи элемент для добавления:");
            int value = Convert.ToInt32(Console.ReadLine());
            int[] tmpArr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                tmpArr[i] = arr[i];
            }
            tmpArr[arr.Length] = value;
            Console.WriteLine("В конец массива добавлен элемент: " + value);
            mArr.UpDate(tmpArr);
        } // completed

        public void AddIndxItem()
        {
            int[] arr = mArr.GetArr();
            int[] tmpArr = new int[arr.Length + 1];
            Console.WriteLine("Введи элемент для добавления:");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи индекс для добавления:");
            int indx = Convert.ToInt32(Console.ReadLine());
            if (indx <= arr.Length)
            {
                for (int i = 0; i < indx; i++)
                {
                    tmpArr[i] = arr[i];
                }
                tmpArr[indx] = value;
                for (int j = indx + 1; j < tmpArr.Length; j++)
                {
                    tmpArr[j] = arr[j - 1];
                }
                Console.WriteLine("\nЭлемент с индексом " + indx + " добавлен!");
            }
            else
            {
                Console.WriteLine("В массиве не существует такого индекса.");
            }
            mArr.UpDate(tmpArr);
        } // completed

        public void ChangeHalfs()
        {
            int[] arr = mArr.GetArr();
            //поменять местами половины массива
            int[] tmpArr = new int[arr.Length];
            int indx;
            if (arr.Length%2 == 0)
            {
                indx = arr.Length / 2;
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    tmpArr[i] = arr[indx];
                    indx += 1;
                }
                indx = 0;
                for (int j = arr.Length / 2; j < tmpArr.Length; j++)
                {
                    tmpArr[j] = arr[indx];
                    indx += 1;
                }
                mArr.UpDate(tmpArr);
                Console.WriteLine("Массив перевернут.");
            }
            else
            {
                Console.WriteLine("Добавь сначала еще 1 элемент в массив.");
            }
        } // completed

        public void ChangePlaces()
        {
            
        } 

        public void ChooseSort()
        {
            throw new NotImplementedException();
        }

        public void Concut()
        {
            int[] arr = mArr.GetArr();
            Random rnd = new Random();
            Console.Write("Введите длинну 2-го массива: ");
            int e = Convert.ToInt32(Console.ReadLine());
            int[] addArr = new int[e];
            int[] fullArr = new int[addArr.Length + arr.Length];
            int startIndx = 0;//, index = 0;

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
            int count = 0;
            for (int j = startIndx + 1; j < fullArr.Length; j++)
            {
                fullArr[j] = addArr[count];
                count++;
            }
            Console.WriteLine("\nМассивы склеены!");
            mArr.UpDate(fullArr);

        } // создать массив сингл тоном

        public void DelItem()
        {
            Console.WriteLine("Введи индекс:");
            int[] arr = mArr.GetArr();
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
            mArr.UpDate(arr);
        } // completed

        public void MaxIndx()
        {
            int[] arr = mArr.GetArr();
            int maxV = arr.Max();
            int indxMax = Array.IndexOf(arr, maxV);
            
            Console.WriteLine("Индекс максимального элемента массива: " + indxMax);
        } // completed

        public void MaxItem()
        {
            int[] arr = mArr.GetArr();
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

        public void MinIndx()
        {
            int[] arr = mArr.GetArr();
            int minV = arr.Min();
            int indxMin = Array.IndexOf(arr, minV);
            Console.WriteLine("Индекс минимального элемента массива: " + indxMin);
        } // completed

        public void MinItem()
        {
            int[] arr = mArr.GetArr();
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

        public void Shake()
        {
            int[] arr = mArr.GetArr();
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
            mArr.UpDate(arr);
            Console.WriteLine("Массив перемешан!");
        } // completed

        public void Show()
        {
            int[] arr = mArr.GetArr();
            Console.WriteLine("М а с с и в : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        } // completed

        public void SumItems()
        {
            int[] arr = mArr.GetArr();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Сумма всех элементов = " + sum);
        } // completed
        public void BubbleSort()
        {
            int[] arr = mArr.GetArr();
            int tmp = 0;
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
            mArr.UpDate(arr);
            Console.WriteLine("Выполнена пузырьковая сортировка.");
        } // completed
        public void InsertSort()
        {

        }
        public void SelectSort()
        {
            int[] arr = mArr.GetArr();
            int tmp;
            for (int i=0; i<arr.Length-1; i++)
            {
                int minI = i;
                for (int j=i+1; j<arr.Length; j++)
                {
                    if (arr[j] < arr[minI])
                    {
                        minI = j;
                    }
                }
                tmp = arr[i];
                arr[i] = arr[minI];
                arr[minI] = tmp;
            }
            mArr.UpDate(arr);
            Console.WriteLine("Выполненая сортировка выбором.");
        } // completed
        public void ShellSort()
        {

        }
        public void MergeSort()
        {

        }
        public void HeapSort()
        {

        }
        public void QuickSort()
        {

        }
        public void Reverse()
        {
            int[] arr = mArr.GetArr();
            int[] tmpArr = new int[arr.Length];
            for (int j = 0, i = arr.Length - 1; i >= 0; i--)
            {
                tmpArr[j] = arr[i];
                j++;
            }

            Console.WriteLine("Массив перевернут.");
            mArr.UpDate(tmpArr);
        } // completed
    }
}
