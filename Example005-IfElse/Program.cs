Console.Write("Введите ваше имя: ");
String username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
