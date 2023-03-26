/*
void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);

    Console.WriteLine();
}

string[] removeElementsOfArray(string[] array) {
    int newArraySize = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i].Length < 4)
            newArraySize++;

    string[] result = new string[newArraySize];

    int indexNew = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i].Length < 4) {
            result[indexNew] = array[i];
            indexNew++;
        }

    return result;
}

Console.WriteLine("Enter a number of elements in the array: ");
int size = Convert.ToInt32(Console.ReadLine());

if (size > 0) 
{
    string[] array = new string[size];
    for(int i = 0; i < size; i++) {
        Console.WriteLine($"Enter the {i + 1} element of the array: ");
        array[i] = Console.ReadLine();
    }

    string[] newArray = removeElementsOfArray(array);

    Console.WriteLine("New array");
    ShowArray(newArray);
} 
else 
{
    Console.WriteLine("The number of elements must be a positive integer number");
}
*/
