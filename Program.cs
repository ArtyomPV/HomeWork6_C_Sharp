//===================  task 1 ======================
/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3+
*/
void CountPositiveNumber(){ 
    Console.Write("Enter any number, how many times you will enter some value: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number <= 0) Console.Write("Error. Enter a number more then zero.");
    else {
        int countPositivNumber = 0;
        for(int i = 0; i < number; i++){
            Console.Write($"Enter the number {i + 1}: ");
            if(Convert.ToInt32(Console.ReadLine()) > 0) countPositivNumber++;
        }

        Console.Write($"\nYou entered {countPositivNumber} positive number.");
    }
}
CountPositiveNumber();

// int[] Array()
// {
//     Console.Write("Enter any number, how many times you will enter some value ");
//     int sizeArray = Convert.ToInt32(Console.ReadLine());
//     int[] arr = new int[sizeArray];
//     for (int i = 0; i < sizeArray; i++)
//     {
//         Console.Write($"\nEnter the number {i + 1}: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }

// void CountNumberBiggerZero(int[] arr){
//     int count = 0;
//     for(int i = 0; i < arr.Length; i++){
//         if(arr[i] > 0) count ++;
//     }
//     Console.WriteLine($" {count}");
// }

// void PrintArray(int[] arr){
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write($"{arr[i]} ");
//     }
// }

// int[] array = Array();
// PrintArray(array);
// Console.Write("->");
// CountNumberBiggerZero(array);


/*
//=================== task 2========================
Задача 43: Напишите программу, которая найдёт точку
 пересечения двух прямых, заданных уравнениями 
 y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

// void FindIntersectionPoint(){
//     string[] nameCoefficient = new string[] {"b1", "k1", "b2", "k2"};
//     double[] valueCoefficient = new double[4];

//     for(int i = 0; i < nameCoefficient.Length; i++){
//         Console.Write($"Enter value of {nameCoefficient[i]}: ");
//         valueCoefficient[i] = Convert.ToInt32(Console.ReadLine());
//     }

//     double x = (valueCoefficient[2]-valueCoefficient[0])/(valueCoefficient[1]-valueCoefficient[3]);
//     double y = valueCoefficient[1]*x + valueCoefficient[0];
//     Console.Write($"({x}; {y})");
// }

// FindIntersectionPoint();

