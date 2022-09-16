/* Задача: Написать программу, которая из имеющегося массива строк
 формирует массив из строк, длина которых меньше либо равна 3 символа. 
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
 выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.
*/

string[] firstArray = new string[6] { "1", "23", "No", "Hello", ":-)", "Yes" };
string[] secondArray = new string[firstArray.Length];

void FinalArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FinalArray(firstArray, secondArray);
PrintArray(secondArray);