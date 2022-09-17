//ЗАДАЧА: Написать программу, которая из имеющегося массива строк
//формирует массив из строк, длина которых меньше либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] array = new string[5] { "no", "d358", "-5", "live", "-89" };
string[] array2 = new string[array.Length];

void GetArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
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
GetArray(array, array2);
PrintArray(array2);