string[] firstArray = new string[10] { "One", "Two", "Three", "Four", "Five", "1", "22", "333", "4444", "55555" };
string[] secondArray = new string[10];
Solution(firstArray, secondArray);
PrintArray(secondArray);


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "    ");
    }
    Console.WriteLine();
}


void Solution(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
