using System;
using System.Collections.Generic;
using System.Text;

namespace dataStruct
{
    interface IFunctions
    {
        public void Show();
        public void AddIndxItem();
        public void AddAppend();
        public void DelItem();
        public void ChangeHalfs(); //поменять половины массива местами
        public void Concut(); //склейка массивов и списков
        public void Shake();
        public void MaxIndx(); //максимальный индекс
        public void MinIndx();
        public void MaxItem();
        public void MinItem();
        public void SumItems();
        public void ChangePlaces(); //поменять местами эелементы по заданным индексам
    }
}
