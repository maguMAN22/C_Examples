int Dist = 10000;
int FFS = 1;
int SFS = 2;
int DS = 5;
int count = 0;
int friend = 2;
int time = 0;

while (Dist > 10)
{
    if (friend == 1)
    {
        time = Dist / (FFS + DS);
        friend = 2;
    }
    else
    {
        time = Dist / (SFS + DS);
        friend = 1;
    }
    Dist = Dist - (FFS + SFS) * time;
    count++;
}
Console.WriteLine(count);