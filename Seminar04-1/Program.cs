//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//Задача 28: произведение чисел от N До M

Console.Clear();
Console.Write("Введите число: ");
string num = Console.ReadLine();
//Console.WriteLine($"В числе {num} {num.Length} цифр(ы)");
int num1 = Convert.ToInt32(num);
//Console.WriteLine($"В числе {num1} {CountNum(num1)} цифр(ы)");
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = MultipleMN(num1,num2);
Console.WriteLine(result);


int CountNum(int num){
    int count = 0;
    while(num > 0){
        num = num/10;
        count++;
    }
    return count;
}

int MultipleMN(int numM, int numN){
    if(numM > numN){
        int temp = numM;
        numM = numN;
        numN = temp;
    }
    int result = numM;
    for(int i = numM+1; i <= numN; i++){
        result = result*i;
    }
    return result;
}



