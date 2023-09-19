
List<List<int>> arr = new List<List<int>>();

for (int i = 0; i < 6; i++)
{
    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
}

List<int>hourglass = new List<int>();

for (int i = 0;i < 6; i++)
{
    for (int j = 2; j < 6; j++)
    {

    }
}