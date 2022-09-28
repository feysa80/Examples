// Создать и отсортировать массив
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = FillArray(size);
PrintArray(newArray);
Console.WriteLine();
int[] sortNewArray = SortArray(newArray);
PrintArray(sortNewArray);


int[] FillArray(int n)
{
    int[] array = new int[n];
    int index = 0;
    while(index < n)
    {
        array[index] = new Random().Next(1, 10);
        index ++;
    }
    return array;
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

int[] SortArray(int[] sort)
{
    int length = sort.Length;
    for(int i = 0; i < length - 1; i++){
    
        int minIndex = i;
        for(int j=i+1; j<length; j++ ){
            if(sort[j] < sort[minIndex]) minIndex = j;
            
        }
        int temp = sort[minIndex];
        sort[minIndex] = sort[i];
        sort[i] = temp;
    }

    return sort;
}