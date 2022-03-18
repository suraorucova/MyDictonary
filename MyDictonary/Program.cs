using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictonary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, double> AdPuan = new Dictionary<string, double>();
            //AdPuan.Add("Sura", 90.45);
            //AdPuan.Add("Yadulla", 98.99);
            //AdPuan.Add("Elif", 75.86);
            //AdPuan.Add("Yusuf", 93.74);
            //foreach (var adPuan in AdPuan)
            //{
            //    Console.WriteLine(adPuan);
            //}
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine(AdPuan.Count);


            MyDictionary<string, double> myDictionary = new MyDictionary<string, double>();
            myDictionary.Add("Ali", 34.5);
            myDictionary.Add("Gafar", 45.6);
            myDictionary.Add("Dilara", 78.9);
            myDictionary.Add("Selim", 67.89);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Ad sayisi: " + myDictionary.Ad + " " + "Puan sayisi: " + myDictionary.Puan);





            Console.ReadLine();
        }
    }
    class MyDictionary<T, T2>
    {
        T[] _array;
        T[] _tempArray;
        T2[] _array2;
        T2[] _tempArray2;
        public MyDictionary()
        {
            _array = new T[0];
            _array2 = new T2[0];
        }

        public void Add(T Ad, T2 Puan)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];

            }

            _tempArray2 = _array2;
            _array2 = new T2[_array2.Length + 1];
            for (int i = 0; i < _tempArray2.Length; i++)
            {
                _array2[i] = _tempArray2[i];
            }


            _array[_array.Length - 1] = Ad;

            _array2[_array2.Length - 1] = Puan;

            Console.WriteLine("Adi:" + Ad + " Puani:" + Puan);
        }
        public int Ad
        {
            get { return _array.Length; }
        }

        public int Puan
        {
            get { return _array2.Length; }
        }
    }
}
