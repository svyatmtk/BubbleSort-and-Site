class BubbleSort 
{ 
    public static void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }
    }
    private static void Swap(ref int arrElem1, ref int arrElem2)
    {
        int swap = arrElem1;
        arrElem1 = arrElem2;
        arrElem2 = swap;
    }
    public static void CreateArrOfRandomNumbers(int[] arr)
    {
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 100);
        }
    }
    public static void ShowArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i] );
        }
        Console.WriteLine();
    }
    public static void Main()
    {
        int[] arr = new int[10];
        CreateArrOfRandomNumbers(arr);
        ShowArr(arr);
        Sort(arr);
        ShowArr(arr);

    }
}