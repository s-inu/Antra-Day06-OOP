namespace OOP;

public class Fib
{
  public static void Main(string[] args)
  {
    for (int i = 1; i <= 10; i++)
    {
      int fib = Fibonacci(i);
      Console.WriteLine($"{fib}");

    }
  }
  public static int Fibonacci(int n)
  {
    if (n <= 2) { return 1; }

    int a = 1;
    int b = 1;
    int c = a + b;

    for (int i = 0; i < n - 2; i++)
    {
      c = a + b;
      a = b;
      b = c;
    }

    return c;
  }

}
