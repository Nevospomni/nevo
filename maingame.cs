using System;
using System.Collections.Generic;
namespace LR6
{
    class Info
    {
        string word;
        string month;
        int time;
        public string Word
        {
            get
            {
                return word;
            }
            set
            {
                word = value;
            }
        }
        public string Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
        public int Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }

        }
        public override string ToString()
        {
            return string.Format(this.Word + " " + this.Month + " " + this.Time);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Стек");
            Stack<Info> st1 = new Stack<Info>();
            st1.Push(new Info { Word = "How", Month = "October", Time = 19 });
            st1.Push(new Info { Word = "Are", Month = "May", Time = 12 });
            st1.Push(new Info { Word = "You", Month = "June", Time = 01 });
            foreach (Info s in st1)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("Двусвязный список");
            LinkedList<Info> st2 = new LinkedList<Info>(st1);
            foreach (Info s in st2)
            {
                Console.WriteLine(s.ToString());
            }
            Console.ReadKey();
        }
    }
}
