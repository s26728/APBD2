static float average(int[] input)
{
    float res = 0;
    foreach (var v in input)
    {
        res += v;
    }
    return res/input.Length;
}

static int findMax(int[] input)
{
    int max = input[0];
    foreach (var v in input)
    {
        if (v>max)
        {
            max = v;
        }
    }

    return max;
}

int[] arr = new[] { 12, 0, 1, 4, 34, -1, 5 };
Console.WriteLine(findMax(arr));