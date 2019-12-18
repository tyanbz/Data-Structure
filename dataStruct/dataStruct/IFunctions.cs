using System;
using System.Collections.Generic;
using System.Text;

namespace dataStruct
{
    interface IFunctions
    {
        public void ChooseSort(int[] arr);
        public void Show(int[] arr);
        public int[] AddIndxItem(int[] arr);
        public int[] AddAppend(int[] arr);
        public int[] DelItem(int[] arr);
        public void ChangeHalfs(int[] arr); //поменять половины массива местами
        public int[] Concut(int[] arr); //склейка массивов и списков
        public void Shake(int[] arr);
        public void MaxIndx(int[] arr); //максимальный индекс
        public void MinIndx(int[] arr);
        public void MaxItem(int[] arr);
        public void MinItem(int[] arr);
        public void SumItems(int[] arr);
        public void ChangePlaces(int[] arr); //поменять местами эелементы по заданным индексам
    }
}
