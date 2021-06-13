using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericsDemo
{
    public class Addition<T>
    {
        public void Add(T a, T b)
        {
            Console.WriteLine("Addition Performed = " + a + b);
        }
    }

    public class Generics
    {
       
        public static void GenericsMain()
        {
            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add("it is a string in array list");
            list.Add(true);
            list.Add(1);

            int value = (int)list[1];

            List<string> lst = new List<string>();

            //lst.Add(1);
            lst.Add("string");

            Addition<float> obj = new Addition<float>();
            obj.Add(4.5f, 5.5f);

            Console.WriteLine("Calling from generics");
        }
    }
}
