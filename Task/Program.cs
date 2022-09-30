// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,  
// длина которых меньше, либо равна 3 символам.


Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[size];
int lenght = 3;
int position = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива: ");
    string element = Convert.ToString(Console.ReadLine());
    if (element.Length <= lenght)
    {
        arrayStrings[position] = element;
        position++;
    }
}
Console.WriteLine();
PrintArray(arrayStrings);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

