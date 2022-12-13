// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами

string[] arrayOne = new string[5] {"563", "12354", "helloWorld", "25", "One"};
string[] arrayTwo = new string[arrayOne.Length];
void SecondArray(string[] arrayOne, string[] arrayTwo)
{
    int n = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
    if(arrayOne[i].Length <= 3)
        {
        arrayTwo[n] = arrayOne[i];
        n++;
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
SecondArray(arrayOne, arrayTwo);
PrintArray(arrayTwo);