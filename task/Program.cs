/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] MyArrayFirst = new string[4] {"Hello", "2", "world", ":-)"};
string[] MyArraySecond = new string [MyArrayFirst.Length];

void ArrayStringLengthThree(string[] ArrayFirst, string[] ArraySecond)
{
    int count = 0;
    for (int i = 0; i < ArrayFirst.Length; i++)
    {
        if(ArrayFirst[i].Length <= 3)
        {
            ArraySecond[count] = ArrayFirst[i];
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

ArrayStringLengthThree(MyArrayFirst, MyArraySecond);
PrintArray(MyArraySecond);
