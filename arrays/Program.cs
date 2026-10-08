namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region arrays1d
            int size = 5;

            int[] number = new int[size];
            number[0] = 1;
            number[1] = 2;

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            size = 10;
            
            int [] buff = new int[number.Length];

            buff = number;

            number = new int[size];

            number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            number = buff;

            Console.WriteLine("/////////////////////////////////////");

            foreach(int i in number)
            {
                Console.WriteLine(i);
            }









            #endregion

            #region ARRAYnD

            int[,] array2 = new int[2, 3];

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = i + j;
                }
            }
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write(array2[i, j] + " ");

                }
                Console.WriteLine();
            }


           

            int[][] array3 = new int[3][];
            array3[0] = new int[] { 1, 2 };
            array3[1] = new int[] { 3, 4, 5 };
            array3[2] = new int[] { 1 };


            #endregion

            #region teory

            /*
            GetLength - повертає кількість елементів за заданим виміро
            GetLowerBound і GetUpperBound - повертають нижню та верхню межу масиву за заданим виміром
            CopyTo - копіює всі елементи одного одновимірного масиву в інший із заданої позиціх
            Clone - копіює, але повертає у вигляді масиву System.Object[].
            System.Object - базовий клас для всіх типів та класів
            BinarySearch - бінарний пошук
            Clear - присвоює значення за замовченням
            IndexOf - повертає індекс першого входження шуканого елемента, у разі не вдачі повертає -1
            LastIndexOf - повертає індекс останнього входження шуканого елемента, у разі не вдачі повертає -1
            Resize - змінює розмір масиву
            Reverse - перевертає массив
            Sort - сортує масив
            Contains
            ///////////////////
            Summ
            Average
            Max
            Min
            //////////////////
            Length - повертає довжину масиву
            Rank - повертає вимір масиву
            */

            #endregion


            #region practic
            #region #1
            //Створіть додаток, який відображає кількість парних, непарних, унікальних елементів масиву.
            int len = 10;
            int parn = 0;
            int unparn = 0;
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i = 0; i<arr.Length; i++)
            {              
                if(arr[i] % 2 == 0)
                {
                    parn++;
                }
                else
                {
                    unparn++;
                }
            }
            Console.WriteLine("col parn: " + parn + " col unparn: " + unparn);

            #endregion
            #region #2
            //Створіть додаток, який відображає кількість
            //значень у масиві, менших за заданий користувачем параметр. Наприклад,
            //кількість значень менших, ніж 7 (7 введено користувачем з клавіатури).
            int[] arr0 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int a = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr0[i] < a)
                {
                    counter++;
                }
            }
            Console.WriteLine("numbers < " + a + " = " + counter);
            #endregion
            #region #3
            /*
            Користувач вводить із клавіатури три числа. Необхідно підрахувати скільки разів послідовність із цих трьох чисел зустрічається в масиві.
            Наприклад:
            користувач ввів: 7 6 5.
            масив: 7 6 5 3 4 7 6 5 8 7 6 5.
            кількість повторень послідовності: 3.
            */
            int[] arr1 = new int[3];
            int[] arr2 = new int[] { 4, 5, 6, 1, 2, 3, 4, 5, 6, 7, 8, 9, 4, 5, 6  };
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            int index = 0;
            int counter1 = 0;
            for (int i = 0;i < arr2.Length; i++)
            {
                index = arr2.IndexOf(arr1[0]);
                if (arr1[0] == arr2[index] && arr1[1] == arr2[index+1] && arr1[2] == arr2[index+2])
                {
                    counter1++;
                }
    
            }


            Console.WriteLine(counter);
            Console.WriteLine();

            #endregion
            #region #4
            //Дано 2 масиви розмірності M і N відповідно.
            //Необхідно переписати до третього масиву загальні елементи перших двох масивів без повторень.
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int length = m > n ? m : n;
            int[] arr3 = new int[m];
            int[] arr4 = new int[n];

            for (int i = 0; i < m; i++)
            {
                arr3[i] = i;
            }
            for (int i = 0; i < m; i++)
            {
                arr4[i] = i;
            }
            
            int[] arr5 = new int[length];

            for (int i = 0; i < (length) ; i++)
            {
                if (arr3[i] == arr4[i] )
            }
            #endregion
            #endregion
        }
    }
}
