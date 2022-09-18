// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 

 Console.WriteLine("Введите строки: ");
string[] stringArray1 = new string[10];
for(int i = 0; i < stringArray1.Length; i++)
{
    stringArray1[i] = Console.ReadLine();
}
string[] stringArray2 = new string [stringArray1.Length];

void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
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

NewArray(stringArray1, stringArray2);
Console.WriteLine(" ");
Console.WriteLine("Новый массив: ");
PrintArray(stringArray2);