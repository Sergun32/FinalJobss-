// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.



Console.Write("Задайте размер массива строк:\t");
int elements = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[elements];

for (int i = 0; i < firstArray.Length; i++)
{
    Console.Write($"Введите значение элемента {i+1}:\t");
    firstArray[i] = Console.ReadLine();
}
string[] secondArray = new string[firstArray.Length];
void SecondArrayFull(string[] firstArray, string[] array2)
{
    int box = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            array2[box] = firstArray[i];
            box++;
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
SecondArrayFull(firstArray, secondArray);
Console.Write("Результат:  ");
PrintArray(secondArray);


