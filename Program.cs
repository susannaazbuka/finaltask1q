string[] array1;
Console.WriteLine("Введите значения строк через пробел для формирования первоначального массива:");
string inputStrings = Console.ReadLine();
array1 = inputStrings.Split(' ');

string[] array2 = new string[array1.Length];

void FillSecondArray(string[] array1, string[] array2)
{
    int i = 0;
    for (int j = 0; j < array1.Length; j++)
    {
        if (array1[j].Length <= 3)
            {
            array2[i] = array1[j];
            i++;
            }
        }
}

void PrintArray(string[] array)
{
    Console.WriteLine("Вывод массива из строк, длина которых меньше либо равна 3 символам:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

FillSecondArray(array1, array2);
PrintArray(array2);