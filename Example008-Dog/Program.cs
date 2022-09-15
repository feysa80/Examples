int count = 0;
double distance = 5000 ;
int firstSpeed = 3;
int secondSpeed = 4;
int dogSpeed = 7;
int friend = 1;
double time = 0;
while(distance > 5)
{
    if(friend == 1)
    {
        time = distance / (firstSpeed + dogSpeed);
        friend = 2;
    } else {
        time = distance / (secondSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - time * (firstSpeed + secondSpeed);
    count ++;
}
Console.WriteLine(count);
