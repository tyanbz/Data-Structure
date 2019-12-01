using System;
// план проекта
// video #20, 61
/* A List0{
 * int[] массив
 * конструктор
 * add в конец
 * add по индексу
 * del по индексу
 * все сортировки массива
 * переворот массива
 * перемешивание отсортированного массива
 * ООП
 * min max element & index
 * сумма элементов массива
 * поменять местами половины массива
 * склейка массивов
 * создание и сотировка 2-мерного массива
 * списки
 * покрыть всё тестом
 */

namespace dataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            AList arrList = new AList(arr);

            arrList.FillArray();

            arrList.ShowArray();
            Console.WriteLine("__________");
            //arrList.DelIndx(5); //убрать 0 в конце массива
            //arrList.ShowArray();
            //arrList.AddIndx(3, 55);
            //arrList.ShowArray();
            //arrList.AddAppend(55);
            //arrList.ShowArray();

            //int[] arrForConcut = arrList.CreateArr();
            //arrList.Concut(arrForConcut);
            //arrList.ShowArray();

            //arrList.ChangePlaces();
            //arrList.ShowArray();

            //int max = arrList.MaxElems();
            //int min = arrList.MinElems();
            //int indxMax = arrList.MaxIndex();
            //int indxMin = arrList.MinIndex();
            //Console.WriteLine("\nМаксимальный элеменет = " + max + "\nс индексом " + indxMax + ".\n");
            //Console.WriteLine("\nМинимальный элеменет = " + min + "\nс индексом " + indxMin + ".");
            //Console.WriteLine("\nСумма элеменетов = " + arrList.SumElements());

            //arrList.Reverse();
            //arrList.ShowArray();

            //arrList.BubbleSort();
            //arrList.ShowArray();

            //arrList.SelectSort(); // реализовать
            //arrList.ShowArray();

            //arrList.Shake();
            //arrList.ShowArray();

            arrList.InsertSort();
            arrList.ShowArray();

            arrList.QuickSort();
            arrList.ShowArray();
        }
    }
}
