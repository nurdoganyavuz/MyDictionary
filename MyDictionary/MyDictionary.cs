using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        //anahtarlar ve değerler için 2 ayrı array oluşturma
        //sözlüğün arkaplanında veriler bu dizilerde tutulacak.

        TKey[] keys;
        TValue[] values;

        //constructor --> yeni sözlük olusturdugumda çalışacak blok

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value) //hangi tipte key veya value girersek, o tipe göre çalışır.
        {
            //ekleme işleminde keys ve values dizileri için bellekte yeni adres oluşacagından, dizileri newlemeden önce
            //bellekteki adreslerini geçici dizilere tuttururuz. 
            //Yani şu an tempArrayKey bellekte keys dizisinin adresini tutar, tempArrayValue ise values dizisinin adresini tutar.
            //newlendiği andan itibaren bu diziler baska adreslere atanacagı için, eski adresleri kaybolmasın diye geçici arraylere tuttururuz.

            TKey[] tempArrayKey = keys; 
            TValue[] tempArrayValue = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                keys[i] = tempArrayKey[i];
            }
            keys[keys.Length - 1] = key; //sözlüğün sonunda eklemek için son index'e atarız girilen key'i

            for (int j = 0; j < tempArrayValue.Length; j++)
            {
                values[j] = tempArrayValue[j];
            }
            values[values.Length - 1] = value; //sözlüğün sonunda eklemek için son index'e atarız girilen value'u.
        }

        public void GetAll() //key ve valueları listeleme metodu
        {
            for (int i = 0; i < keys.Length; i++) //keys.length ya da values.length kullanırız; çünkü ikisinin boyutu da aynı. 
            {                                     //ne kadar keys o kadar value :)

                Console.WriteLine("Key: " + keys[i] + " | Value: " + values[i]);

            }
        }

    }
}