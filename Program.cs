// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
//промежутке от M до N. Использовать рекурсию, не использовать циклы.

// int ReadInt(string str)
// {
//     System.Console.Write(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void PrintNumbers(int M, int N)
//     {
//         if (M > N) return;
//             if (M < N)
//             PrintNumbers(M, N - 1);
//             System.Console.Write(N + " ");
//     }       
// int M = ReadInt("Введите число M: ");
// int N = ReadInt("Введите число N: ");

// PrintNumbers(M, N);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// int ReadInt(string str)
// {
//     System.Console.Write(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int Akkerman (int M, int N)
// {
//     if (M == 0) 
//     return N + 1;

//     if ((M > 0) && (N == 0)) 
//     return Akkerman(M -1, 1);

//     else 
//     return Akkerman(M - 1, Akkerman (M, N - 1));
// }


// int M = ReadInt("Введите число M: ");
// int N = ReadInt("Введите число N: ");
// Akkerman(M, N);
// Console.WriteLine(Akkerman(M, N));

// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] GenerateArray(int size, int leftRange, int rightRange)
//     {
//         int[] tempArray = new int[size];
//         Random rand = new Random();

//             for (int i = 0; i < size; i++)
//             {
//                 tempArray[i] = rand.Next(leftRange, rightRange);
//             }
// return tempArray;
//     }

// void PrintArray(int[] array)
//     {
//         System.Console.WriteLine($"[{string.Join(", ", array)}]");
//     }

// int Array(int []array, int size, int index)
// {
//     Console.WriteLine(Array(array, size, index + 1) + array[index]);

//     if (index == size) return array[index];
//     else
//     return array[index] - Array(array,size,index + 1);
// }

// int size = ReadInt("Введите размер массива: ");
// int[] myArray = GenerateArray(size, 1, 100);
// PrintArray(myArray);

// Console.WriteLine(Array(Array, size, index + 1) + Array[index]);
