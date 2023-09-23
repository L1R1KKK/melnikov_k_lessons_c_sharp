int[] array = { 1, 212, 333, 412, 18,  5, 6, 17, 18 };

int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1
    index++;
}
