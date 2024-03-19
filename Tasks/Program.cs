static float average(int[] input)
{
    float res = 0;
    foreach (var l in input)
    {
        res += l;
    }
    return res/input.Length;
}
int[] arr = new []{1, 12, 0, 3, 4, 1};
Console.WriteLine(average(arr));