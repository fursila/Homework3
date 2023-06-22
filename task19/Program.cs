Console.WriteLine ("введите число: ");
int N = int.Parse(Console.ReadLine()!);
int a = N%10;
int b = N%100/10;
int c = N/10000;
int d = N/1000%10;
if (a == c) {
    if (b==d) Console.WriteLine ("палиндром");
} 
else Console.WriteLine ("не палиндром");