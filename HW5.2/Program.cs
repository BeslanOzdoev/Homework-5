//Написать программу масштабирования фигуры

double[] Input(string[] num, double k)
{
    double[] mas = new double[num.Length];
    for (int ind = 0; ind < num.Length; ind++)
    {
        mas[ind] = (double.Parse(num[ind])) * k;
    }
    return mas;
}

void Output(double[] massiv)
{
    for (int i = 0; i < massiv.Length; i+=2)
    {
        Console.Write($"({massiv[i]}, {massiv[i+1]})  ");
    }
}

Console.Write("Введите координаты точек фигуры через запятую ',': ");
string[] num = (Console.ReadLine() ?? "0").Split(',');
Console.Write("Введите коэфициент масштабирования: ");
double k = double.Parse(Console.ReadLine() ?? "0");
double l = 1;
double[] current_fig = Input(num, l);
Console.Write("Координаты текущей фигуры: ");
Output(current_fig);
Console.WriteLine();
Console.Write("Координаты фигуры после масштабирования: ");
double[] new_fig = Input(num, k);
Output(new_fig);