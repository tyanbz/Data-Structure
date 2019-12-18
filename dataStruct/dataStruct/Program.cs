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
            string mainMenu ="ГЛАВНОЕ МЕНЮ\n" +
                "[1] - Зайти в меню с массивами\n" +
                "[2] - Зайти в меню с односвязными листами\n" +
                "[3] - Зайти в меню с двусвязными листами\n" +
                "-----------------------------------------\n" +
                "[0] - Выход\n";

            string arrayMenu = "МЕНЮ МАССИВОВ\n" +
                "[1] - Создать новый одномерный массив\n" +
                "[2] - Показать одномерный массив\n" +
                "-----------------------------------------------------\n" +
                "[3] - Найти минимальный элемент массива\n" +
                "[4] - Найти индекс минимального элемента массива\n" +
                "[5] - Найти максимальный элемент массива\n" +
                "[6] - Найти индекс максимального элемента массива\n" +
                "-----------------------------------------------------\n" +
                "[7] - Поменять местами эелементы по заданным индексам\n" +
                "[8] - Посчитать сумму всех элементов\n" +
                "[9] - Добавить элемент по индексу\n" +
                "[89] - Добавить элемент в конец массива\n" +
                "[99] - Удалить элемент массива по индексу\n" +
                "-----------------------------------------------------\n" +
                "[11] - Поменять местами 2 половины массива\n" +
                "[22] - Перемешать массив\n" +
                "[33] - Склеить 2 массива\n" +
                "-----------------------------------------------------\n" +
                "[44] - Пузыроьковая сортировка\n" +
                "[55] - Сортировка выбором\n" +
                "[66] - Сортировка вставками\n" +
                "[88] - Shell сортировка\n" +
                "[99] - Merge сортировка\n" +
                "[12] - Heap сортировка\n" +
                "[13] - Быстрая сортировка\n" +
                "[14] - Реверсия массива\n" +
                "------------------------------\n" +
                "[0] - Назад в главное меню\n";
            string listMenu = "МЕНЮ С ОДНОМЕРНЫМИ ЛИСТАМИ\n" +
                "[1] - здесь пока ничего нет" +
                "-----------------------------------------------------\n" +
                "[0] - Назад в главное меню\n";
            string doubleListMenu = "МЕНЮ С ДВУМЕРНЫМИ ЛИСТАМИ\n" +
                "[1] - здесь пока ничего нет" +
                "----------------------------------------------------\n" +
                "[0] - Назад в главное меню\n";
            int[] arr = new int[10];
            int userSelect = 111;
            ArrList array = new ArrList();

            while (userSelect != 0)
            {
                Console.WriteLine("\n" + mainMenu + "\n");
                userSelect = Convert.ToInt32(Console.ReadLine()); ;
                
                switch (userSelect)
                {
                    case 1: // меню массивов
                        userSelect = 20;
                        while (userSelect != 0)
                        {
                            Console.WriteLine("\n" + arrayMenu + "\n");
                            userSelect = Convert.ToInt32(Console.ReadLine());

                            switch (userSelect)
                            {
                                case 1:
                                    Console.WriteLine("Введите размер массива: ");
                                    int length = Convert.ToInt32(Console.ReadLine());
                                    arr = array.CreateArr(length);
                                    Console.WriteLine("Массив создан!");
                                    break;
                                case 2:
                                    array.Show(arr);
                                    break;
                                case 3:
                                    array.MinItem(arr);
                                    break;
                                case 4:
                                    array.MinIndx(arr);
                                    break;
                                case 5:
                                    array.MaxItem(arr);
                                    break;
                                case 6:
                                    array.MaxIndx(arr);
                                    break;
                                case 7:
                                    array.ChangePlaces(arr);
                                    break;
                                case 8:
                                    array.SumItems(arr);
                                    break;
                                case 9:
                                    arr = array.AddIndxItem(arr);
                                    break;
                                case 89:
                                    arr = array.AddAppend(arr);
                                    break;
                                case 99:
                                    arr = array.DelItem(arr);
                                    break;
                                case 11:
                                    array.ChangeHalfs(arr);
                                    break;
                                case 22:
                                    array.Shake(arr);
                                    break;
                                case 33:
                                    arr = array.Concut(arr);
                                    break;
                                case 44:
                                    array.BubbleSort(arr);
                                    break;
                                case 55:
                                    array.SelectSort(arr);
                                    break;
                                case 66:
                                    array.InsertSort(arr);
                                    break;
                                //case 77:
                                 //   array.ShellSort(arr);
                                //    break;
                                case 88:
                                    array.ShellSort(arr);
                                    break;
                                case 12:
                                    array.MergeSort(arr);
                                    break;
                                case 13:
                                    array.HeapSort(arr);
                                    break;
                                case 14:
                                    array.QuickSort(arr);
                                    break;
                                case 15:
                                    array.Reverse(arr);
                                    break;
                                case 0:
                                    userSelect = 0;
                                    break;
                                default: break;
                            }
                        }
                        userSelect = 20;
                        break;
                    case 2: // МЕНЮ ОДНОСВЯЗНЫХ СПИСКОВ
                        userSelect = 20;
                        while (userSelect != 0)
                        {
                            Console.WriteLine("\n" + listMenu + "\n");
                            userSelect = Convert.ToInt32(Console.ReadLine());

                            switch (userSelect)
                            {
                                case 1:

                                    break;
                                case 2:
                                    break;
                                case 3:

                                    break;
                                case 4:

                                    break;
                                case 5:

                                    break;
                                case 6:

                                    break;
                                case 0:
                                    userSelect = 0;
                                    break;
                                default: break;
                            }
                        }
                        userSelect = 20;
                        break;
                    case 3: // МЕНЮ ДВУСВЯЗНЫХ СПИСКОВ
                        userSelect = 20;
                        while (userSelect != 0)
                        {
                            Console.WriteLine("\n" + listMenu + "\n");
                            userSelect = Convert.ToInt32(Console.ReadLine());

                            switch (userSelect)
                            {
                                case 1:

                                    break;
                                case 2:
                                    break;
                                case 3:

                                    break;
                                case 4:

                                    break;
                                case 5:

                                    break;
                                case 6:

                                    break;
                                case 0:
                                    userSelect = 0;
                                    break;
                                default: break;
                            }
                        }
                        userSelect = 20;
                        break;
                    case 0:
                        userSelect = 0;
                        break;
                    default: break;
                }
            }
        }
    }
}
