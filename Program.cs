public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[] { 5, 3, 3, 4, 5, 4, 1, 1, 2, 4 };
        foreach (int num in arr)
        {
            Console.WriteLine("input array element:" + num);
        }
        int[] arr1 = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr1[i] = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (i != j && arr[i] == arr[j])
                {
                    arr1[i]++;
                    continue;
                }
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr1[i] == 1)
                Console.WriteLine("output array:" + arr[i]);
        }
    }
}