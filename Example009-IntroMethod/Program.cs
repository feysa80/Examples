void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}
void PrintArray(int[] col)
{
    int index = 0;
    while(index < col.Length)
    {
        Console.Write(col[index] + ", ");
        index++;
    }

   
}
int IndexOf(int[] collect, int find)
{
    int result = -1;
    int index = 0;
    while(index < collect.Length)
    {
        if(collect[index] == find) 
        {
            result = index;
            break;
        }
        index++;
    }
    return result;
}
Console.Clear();
int[] array = new int[9];
FillArray(array);
PrintArray(array);
int res = IndexOf(array, 5);
Console.WriteLine();
Console.WriteLine(res);

