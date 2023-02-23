
int a = 1;
int b = 42;
int c = 9;
int d = 7;
int e = 23;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine (max);