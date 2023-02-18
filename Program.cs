Console.Clear();
link1:
Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine());
int b = a;
if (a < 10000 || a > 99999)
{
    Console.WriteLine("Вы ввели не корректное число");
    goto link1;
}
int[] array = new int[5];
for (int i = 4; i >= 0; i--) 
{
    array[i] = a % 10;
    a /= 10;
}
if (array[0] == array[4] && array[1] == array[3])
{ Console.WriteLine("Число " + b + "  палиндром");}
else{ Console.WriteLine("Число " + b + "  непалиндром");}