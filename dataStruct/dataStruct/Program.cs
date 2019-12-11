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
            string menu = "[0] - Создать новый одномерный массив\n" +
                "[1] - Создать односвязный список\n" +
                "[2] - Создать двусвязный список\n" +
                "--------------------------------\n" +
                "[3] - Показать одномерный массив\n" +
                "[4] - Показать односвязный список\n" +
                "[5] - Показать двусвязный список\n" +
                "--------------------------------\n" +
                "[6] - Выход\n";
            int[] arr = new int[10];
            int userSelect = 111;
            ArrList array = new ArrList();

            while (userSelect != 6)
            {
                Console.WriteLine("Выбери 1 из пунктов меню:\n" + menu);
                userSelect = Convert.ToInt32(Console.ReadLine()); ;

                switch (userSelect)
                {
                    case 0:
                        Console.WriteLine("Введите размер массива: ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        arr = array.CreateArr(length);
                        Console.WriteLine("Массив создан!");
                        break;
                    case 1:
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        array.Show(arr);
                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:
                        userSelect = 6;
                        break;
                    default: break;
                }
            }







            //int[] arr = new int[20];
            //AList arrList = new AList(arr);

            //arrList.FillArray();

            //arrList.ShowArray();
            //Console.WriteLine("__________");
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

            //arrList.InsertSort();
            //arrList.ShowArray();

            //arrList.QuickSort();
            //arrList.ShowArray();
        }
    }
}
