using static Methods.Collections_Methods.Array_Methods;

namespace Методы_Array
{
    internal class Program
    {
        static int Move(int i, int n, ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.UpArrow)
            {
                i = (n + i - 1) % n;
            }

            if (key.Key == ConsoleKey.DownArrow)
            {                
                i = (i + 1) % n;
            }

            return i;
        }
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int i = 0, n = 9;

            while (true)
            {
                
                Console.SetCursorPosition(0, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Массив: [" + String.Join(", ", array) + "]");

                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Отсортировать по возрастанию"); //Sort
                Console.WriteLine("Перевернуть"); // Reverse
                Console.WriteLine("Бинарный поиск"); // BinarySearch
                Console.WriteLine("Очистить"); // Clear
                Console.WriteLine("Установить значение"); // SetValue
                Console.WriteLine("Индекс первого вхождения элемента"); // IndexOf
                Console.WriteLine("Индекс последнего вхождения элемента"); // LastIndexOf
                Console.WriteLine("Получить значение по индексу"); // GetValue
                Console.WriteLine("Длина массива"); // Это вообще свойство, но я не знаю, что ещё добавить
                Console.SetCursorPosition(40, i);

                ConsoleKeyInfo key = Console.ReadKey();

                if (i == 0 && key.Key == ConsoleKey.Enter)
                {
                        array = Sort(array);
                }

                if (i == 1 && key.Key == ConsoleKey.Enter)
                {
                    array = Reverse(array);
                }

                if (i == 2 && key.Key == ConsoleKey.Enter)
                {
                    BinarySearch(array);
                }

                if (i == 3 && key.Key == ConsoleKey.Enter)
                {
                    array = Clear(array);
                }

                if (i == 4 && key.Key == ConsoleKey.Enter)
                {
                    array = SetValue(array);
                }

                if (i == 5 && key.Key == ConsoleKey.Enter)
                {
                    IndexOf(array);
                }

                if (i == 6 && key.Key == ConsoleKey.Enter)
                {
                    LastIndexOf(array);
                }

                if (i == 7 && key.Key == ConsoleKey.Enter)
                {
                    GetValue(array);
                }

                if (i == 8 && key.Key == ConsoleKey.Enter)
                {
                    Length(array);
                }

                i = Move(i, n, key);
            }
        }
    }
}