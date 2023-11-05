
//              Array Rotation
//•	Reads an array with integer numbers (separated with single space) from the first line of the console
//•	Reads an integer number N (count of rotations) from the second line of the console
//•	During each rotation the last element goes at the start of the array (last number becomes first)
//•	Print the resulting sequence separated by comma and a single space (", ")







int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rotations = int.Parse(Console.ReadLine());
int length = numbers.Length;


for (int i = 0; i < rotations; i++)
{
    int lastNum = numbers[length - 1];

    for (int j = length - 1; j > 0; j--)
    {
        numbers[j] = numbers[j - 1];
    }

    numbers[0] = lastNum;
}


Console.WriteLine(string.Join(", ", numbers));
