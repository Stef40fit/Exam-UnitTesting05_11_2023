
//Въртене на Списък N на брой пъти

List<int> ListNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int rotations = int.Parse(Console.ReadLine());


for (int i = 0; i < rotations; i++)
{
    int currentNum = ListNumbers[0];

    ListNumbers.Remove(ListNumbers[0]);
    ListNumbers.Add(currentNum);
}

Console.WriteLine(string.Join(" ", ListNumbers));
