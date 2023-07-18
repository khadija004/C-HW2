//Task1


//Console.WriteLine("Faizi daxil edin");
//int.TryParse(Console.ReadLine(), out int precent);
//int[] arr = { 0, 50, 100, 150, 200, 250, 300, 350, 400 };

//int sum = FindSum(precent, arr);
//Console.WriteLine(sum);


//static int FindSum(int precent, int[] arr)
//{
//    int sum = default;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] < 20)
//        {
//            arr[i] += (arr[i] * precent) / 100;
//        }
//        sum += arr[i];
//    }
//    return sum;

//}


//Task2

Console.WriteLine("Deyisiklik etmek istediyiniz sozu daxil edin");
string name=Console.ReadLine();

Console.WriteLine("Indeksi daxil edin");
int.TryParse(Console.ReadLine(), out int index);

RemoveStting(name, index);


static void RemoveStting(string name,int index)
{
    for (int i = 0; i < name.Length; i++)
    {
        if (i == index)
        {
            continue;
        }
        Console.Write(name[i]);
    }
}