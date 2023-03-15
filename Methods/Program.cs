namespace Methods
{
    public class Collections_Methods
    {
        public class Array_Methods : Collections_Methods 
        {
            public static int[] Sort(int[] arr) // Sort
            {
                Array.Sort(arr);
                return arr;
            }

            public static int[] Reverse(int[] arr) // Reverse
            {
                Array.Reverse(arr);
                return arr;
            }

            public static void BinarySearch(int[] arr) // BinarySearch
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                int[] copy = new int[arr.Length];
                arr.CopyTo(copy, 0);
                Array.Sort(copy);

                bool flag = true;

                for (int i=0; i<copy.Length; i++)
                {
                    if (copy[i] != arr[i])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    Console.WriteLine("Какое число найти?");
                    int number = int.Parse(Console.ReadLine());
                    int index = Array.BinarySearch(arr, number);
                    Console.WriteLine("Искомый индекс = " + index);
                }
                else
                    Console.WriteLine("Массив не отсортирован");

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();

            }

            public static int[] Clear(int[] arr)
            {
                Array.Clear(arr);
                return arr;
            }

            public static int[] SetValue(int[] arr)
            {
                Console.Clear();
                
                Console.WriteLine("По какому индексу изменить значение?");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine("Какое значение присвоить?");
                int value = int.Parse(Console.ReadLine());

                arr.SetValue(value, index);

                Console.Clear();

                return arr;
            }

            public static void IndexOf(int[] arr)
            {
                Console.Clear();

                Console.WriteLine("Индекс какого элемента показать?");
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine("Индекс первого вхождения: {0}", Array.IndexOf(arr, value));

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void LastIndexOf(int[] arr)
            {
                Console.Clear();

                Console.WriteLine("Индекс какого элемента показать?");
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine("Индекс последнего вхождения: {0}", Array.LastIndexOf(arr, value));

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void GetValue(int[] arr)
            {
                Console.Clear();

                Console.WriteLine("По какому индексу получить значение?");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine("Значение по данному индексу: {0}", arr.GetValue(index));

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }

            public static void Length(int[] arr)
            {
                Console.Clear();
                Console.WriteLine("Длина массива: {0} элементов", arr.Length);

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

                Console.Clear();
            }
            static void Main()
            {

            }
        }
        
    }
}