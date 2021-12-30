using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab4
{

    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> a = new MyList<string>(){ "Бык", "корова", "теленок", "Бык" };
            MyList<string> a1 = new MyList<string>() { "1", "2", "3" };
            Console.WriteLine("Введите слово");
            string b = Console.ReadLine();
            MyList<string> c = a + b;
            foreach (var item in c)
                Console.WriteLine(item);
            c= --c;
            foreach (var item in c)
                Console.WriteLine(item);
            bool k = a!= c;
            Console.WriteLine(k);
            k = a1 != c;
            Console.WriteLine(k);
            c = a * a1;
            foreach (var item in c)
                Console.WriteLine(item);
            MyList<string>.GL(c);
            Console.WriteLine(MyList<string>.GL(c));
            Console.WriteLine(MyList<string>.POVT(c));

        }
    }

    public class MyList<T> : List<T>
    {
        public static MyList<T> operator +(MyList<T> a, T b)
        {
            MyList<T> result = new MyList<T>();
            result.Insert(0, b);
            foreach (T item in a) result.Add(item);
            return result;
        }
        public static MyList<T> operator --(MyList<T> a)
        {
            MyList<T> result = new MyList<T>();
            foreach (T item in a) result.Add(item);
            result.RemoveAt(0);
            return result;
        }
        public static bool operator ==(MyList<T> a, MyList<T> b)
        {
            bool result = a.SequenceEqual(b);
            return result;
        }
        public static bool operator !=(MyList<T> a, MyList<T> b)
        {
            bool result = a.SequenceEqual(b);
            return result;
        }
        public static MyList<T> operator *(MyList<T> a, MyList<T> b)
        {
            MyList<T> result = new MyList<T>();
            foreach (T item in a) result.Add(item);
            foreach (T item in b) result.Add(item);
            return result;
        }
        public static MyList<T> GL(MyList<T> a)
        {
            MyList<T> result = new MyList<T>();
            foreach (T item in a)
            {
                string p = item.ToString();
                string p1 = item.ToString();
                char p2 = p[0];
                if (p1[0] == char.ToUpper(p2))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static MyList<T> POVT(MyList<T> a)
        {
            MyList<T> result = new MyList<T>();
            MyList<T> a1 = new MyList<T>();
            a1.AddRange(a);
            foreach (T lol in a1)
            {
                int i = 0;
                foreach (T item in a)
                {
                    if (lol.ToString() == item.ToString())
                    {
                        if (lol.ToString() == item.ToString() && i >= 1)
                        {
                            result.Add(item);
                        }
                        i++;
                    }
                }
            }
            return result;
        }
        public string Seconds { get; set; }

        public static implicit operator MyList<T>(string x)
        {
            return new MyList<T> { Seconds = x };
        }
        public static explicit operator MyList<T>(string counter)
        {
            return counter.Seconds;
        }

}