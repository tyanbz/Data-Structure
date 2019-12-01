using System;
using System.Collections.Generic;
using System.Text;

namespace dataStruct
{
    public interface IMyList
    {
        void AddAppend(int value);
        void AddIndx(int indx, int value);
        void DelIndx(int indx);
        void BubbleSort();
        void InsertSort();
        void ShellSort();
        void QuickSort();
        void MergeSort();
        void HeapSort();
        void SelectSort();
        void Reverse();
        void Shake();
        int MinElems();// return min elem
        int MaxElems();// return max elem
        int MinIndex();// return min index
        int MaxIndex();// return max index
        int SumElements();
        void ChangePlaces();
        void Concut(int[] arr); // return new array
    }
}
