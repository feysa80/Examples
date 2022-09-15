Console.Clear();
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Последнее число " + (num % 10));
