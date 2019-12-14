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
        }
        public void AddAppend()
        {
            throw new NotImplementedException();
        }

        public void AddIndxItem()
        {
            throw new NotImplementedException();
        }

        public void ChangeHalfs()
        {
            throw new NotImplementedException();
        }

        public void ChangePlaces()
        {
            throw new NotImplementedException();
        }

        public void ChooseSort()
        {
            throw new NotImplementedException();
        }

        public void Concut()
        {
            throw new NotImplementedException();
        }

        public void DelItem()
        {
            throw new NotImplementedException();
        }

        public void MaxIndx()
        {
            throw new NotImplementedException();
        }

        public void MaxItem()
        {
            throw new NotImplementedException();
        }

        public void MinIndx()
        {
            throw new NotImplementedException();
        }

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
        }

        public void Shake()
        {
            throw new NotImplementedException();
        }

        public void Show(int[] arr)
        {
            Console.WriteLine("М а с с и в : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

        public void SumItems()
        {
            throw new NotImplementedException();
        }
    }
}
