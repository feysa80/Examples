Console.Clear();
int num = Convert.ToInt32(Console.ReadLine());
if((num % 7 == 0) && (num % 23 == 0)){
    Console.WriteLine("кратно 7-ми и 23-м");
} else {
    Console.WriteLine("не кратно 7-ми и 23-м");
}
