Console.Clear();
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = num1  % num2;

if(num3 != 0){
    Console.WriteLine($"не кратно,остаток {num3}");
} else {
    Console.WriteLine("кратно");
}
