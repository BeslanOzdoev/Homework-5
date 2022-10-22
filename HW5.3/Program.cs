//Написать программу копирования массива
void Input(int[] massiv)
{
    Random arr1 = new Random();
    for (int ind = 0; ind < massiv.Length; ind++)
    {
        massiv[ind] = arr1.Next(0, 9);
    }
}
void  Output(int[] massiv)
{
    foreach (var item in massiv)
    {
        Console.Write($"{item} ");
    }
}
int[] Copy(int[] massiv1)
{
    int[] Next = new int [massiv1.Length];
    for (int ind = 0; ind < massiv1.Length; ind++)
    {
        Next[ind] = massiv1[ind];
    }
    return Next;
}
Console.Write("Введите длинну массива: ");
int n = int.Parse(Console.ReadLine()?? "0");
int[] Array = new int[n];
Input(Array);
Console.Write("Начальный массив: ");
Output(Array);
Console.WriteLine();
Console.Write("Скопированный массив: ");
int[] Array_copy = Copy(Array);
Output(Array_copy);
