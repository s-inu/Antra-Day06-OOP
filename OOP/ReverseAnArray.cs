namespace OOP;

public class ReverseAnArray
{
  public static void Main(string[] args)
  {
    int[] arr = GenerateNumbers();
    Console.WriteLine($"{string.Join(',', arr)}");
    Reverse(arr);
    Console.WriteLine($"{string.Join(',', arr)}");
  }

  public static int[] GenerateNumbers(int len = 10, int min = 1, int max = 100)
  {
    var rand = new Random();
    int[] ret = new int[len];

    for (int i = 0; i < len; i++)
    {
      ret[i] = rand.Next(min, max + 1);
    }

    return ret;
  }

  public static void Reverse(int[] arr)
  {
    for (int i = 0; i < arr.Length / 2; i++)
    {
      (arr[i], arr[^(i + 1)]) = (arr[^(i + 1)], arr[i]);
    }
  }

  public static void PrintNumbers(int[] arr)
  {
    foreach (int n in arr)
    {
      Console.WriteLine(n);
    }
  }
}
