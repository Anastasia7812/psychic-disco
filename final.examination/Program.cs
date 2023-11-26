//Задача: Написать программу, 
// 1. которая из имеющегося массива строк
// 2. формирует новый массив из строк, (Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.)
// 3. длина которых меньше, либо равна 3 символам.


//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] array1 = new string[5] {"dfjkyfb", "gi", "hello", "123", "rjo"};

string[] array2 = new string[array1.Length];

void SecondArrayWithIF(string[] array1, string[] array2)


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


SecondArrayWithIF(array1, array2);

PrintArray(array2);