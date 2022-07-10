// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] list = new double[8];
double maxElement = list[0];
double minElement = list[0];
double difMinMax = 0;

for (int i = 0; i < list.Length; i++)
{
    list[i] = Math.Round((new Random().Next(-1000,1000) * 0.1),3);
    if (list[i] > maxElement) maxElement = list[i];
    if (list[i] < minElement) minElement = list[i];
    difMinMax = maxElement - minElement;
}

Console.WriteLine($"Выводим массив вещественных чисел: [{String.Join(":",list)}] разница между max: {maxElement} и min: {minElement} равно {difMinMax}");
