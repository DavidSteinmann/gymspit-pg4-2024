namespace Lecture4;

internal class Program
{
    static void Main(string[] args)
    {
        DynamicArray<int> array = new DynamicArray<int>(10);

        array.Add(84);
        array.Add(424);
        array.Add(-1524);

        Console.WriteLine(array.Get(0));
        Console.WriteLine(array.Get(1));
        Console.WriteLine(array.Get(2));

        int a = array.Get(0);


        DynamicArray<string> array2 = new DynamicArray<string>(10);
        array2.Add("Hello");

        Console.WriteLine(array2.Get(0));

        string b = array2.Get(0);



        Data<int> one = new Data<int>(1);
        Data<int> three = new Data<int>(3);

        Data<int> result = one.Add(three);
        Console.WriteLine(result.Value);

        DynamicArrayWithData<Data<int>> test = new DynamicArrayWithData<Data<int>>(10);
        test.GetSum();
    }
}