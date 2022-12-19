int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;

    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    
    return result;
}

int a1 = 11;
int a2 = 13;
int a3 = 21;
int b1 = 80;
int b2 = 41;
int b3 = 189;
int c1 = 19;
int c2 = 13;
int c3 = 12;

//int max1 = Max (a1, a2, a3);
//int max2 = Max (b1, b2, b3);
//int max3 = Max (c1, c2, c3);
//int result = Max(max1, max2, max3);

int result = Max (
    Max (a1, a2, a3),
    Max (b1, b2, b3),
    Max (c1, c2, c3)); // в качестве аргументов передаем функцию

Console.WriteLine(result);