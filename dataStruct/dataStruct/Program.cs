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
        static void  Main(string[] args)
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
                "[12] - Merge сортировка\n" +
                "[13] - Heap сортировка\n" +
                "[14] - Быстрая сортировка\n" +
                "[15] - Реверсия массива\n" +
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
            //MainArray mArr = new MainArray();

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
                                    array.CreateArr(length);
                                    Console.WriteLine("Массив создан!");
                                    break;
                                case 2:
                                    array.Show();
                                    break;
                                case 3:
                                    array.MinItem();
                                    break;
                                case 4:
                                    array.MinIndx();
                                    break;
                                case 5:
                                    array.MaxItem();
                                    break;
                                case 6:
                                    array.MaxIndx();
                                    break;
                                case 7:
                                    array.ChangePlaces();
                                    break;
                                case 8:
                                    array.SumItems();
                                    break;
                                case 9:
                                    array.AddIndxItem();
                                    break;
                                case 89:
                                    array.AddAppend();
                                    break;
                                case 99:
                                    array.DelItem();
                                    break;
                                case 11:
                                    array.ChangeHalfs();
                                    break;
                                case 22:
                                    array.Shake();
                                    break;
                                case 33:
                                    array.Concut();
                                    break;
                                case 44:
                                    array.BubbleSort();
                                    break;
                                case 55:
                                    array.SelectSort();
                                    break;
                                case 66:
                                    array.InsertSort();
                                    break;
                                //case 77:
                                 //   array.ShellSort(arr);
                                //    break;
                                case 88:
                                    array.ShellSort();
                                    break;
                                case 12:
                                    array.MergeSort();
                                    break;
                                case 13:
                                    array.HeapSort();
                                    break;
                                case 14:
                                    array.QuickSort();
                                    break;
                                case 15:
                                    array.Reverse();
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
