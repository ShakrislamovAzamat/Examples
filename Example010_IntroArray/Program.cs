// int Max(int arg1, int arg2, int arg3) //Метод поиска максимума из трех
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// //  index        0  1   2   3   4   5   6   7   8
// int[] array = { 11, 21, 35, 48, 54, 620, 17, 28, 99 };

// int max = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );

// Console.WriteLine(max);


int[] array = { 11, 54, 68, 44, 51, 54, 71, 18 };

int n = array.Length; //количество элементов (длина) массива
int find = 54;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}