﻿using System.Text;
namespace Program
{
    class program
    {
        public static void Main()
        {
            var Stack=new Stack<string>();
            while (true)
            {
                Console.WriteLine("1 - Проверка пустоты \n 2 - Проверка заполненности \n 3 - Добавить Элемент \n 4 - Удалить элемент \n 5 - Вывести Стек \n 6 - Закончить работу");
                string number = (Console.ReadLine());
                switch (number)
                {
                    case "1":
                        Console.WriteLine(Stack.IsEmpty);
                        break;

                    case "2":
                        Console.WriteLine(Stack.IsFull);
                        break;
                    
                    case "3":
                        Console.WriteLine("Введите эелемент");
                        var element = Console.ReadLine();
                        Stack.Add(element);
                        Console.WriteLine("Элемент Добавлен");
                        break;

                    case "4":
                        var deleted = Stack.Del();
                        Console.WriteLine($"Удалён элемент{deleted}");
                        break;

                    case "5":
                        Console.WriteLine($"{Stack}");
                        break;

                    case "6":
                        return;
                   
                }
            }
            
        }
    }
    public class Stack<T> where T : class
    {
        const int n = 10;
        private T[] items=new T[n];
        private int count;    
  
        public bool IsEmpty
        {
            get { return count == 0;}
        }
        public bool IsFull
        {
            get { return count == items.Length; }
        }
        public void Add(T item)
        {
            if (count == items.Length)
                throw new InvalidOperationException("Заполнен");
            items[count++]=item;
        }
        public T Del()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T item = items[--count];
            items[count] = default(T);
            return item;
        }
        public override string ToString()
        {
            var stringbuilder = new StringBuilder();
            foreach (var item in items)
            {
                stringbuilder.Append($"{{{item}}}") ;
            }
            return stringbuilder.ToString();
        }

    }
   
}
