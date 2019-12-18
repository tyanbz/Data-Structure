using System;
using System.Collections.Generic;
using System.Text;

namespace dataStruct
{
    class MainArray
    {
        public MainArray() { }
        public static int[] array;
               
        public void UpDate(int[] arr)
        {
            array = arr;
        }
        public int[] GetArr()
        {
            return array;
        }
    }
}
