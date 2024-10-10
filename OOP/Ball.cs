namespace OOP;

public class Ball(int size, Color color)
{
  public int Size { get; private set; } = size;
  public Color Color { get; set; } = color;
  private int throwCount = 0;
  private bool isPopped = false;

  public static void Main(string[] args)
  {
    Ball ball1 = new(10, new Color(255, 0, 0));
    Ball ball2 = new(15, new Color(0, 255, 0));
    Ball ball3 = new(20, new Color(0, 0, 255));

    ball1.Throw();
    ball1.Throw();
    ball2.Throw();
    ball3.Pop();
    ball3.Throw();

    Console.WriteLine("Ball 1 Throws: " + ball1.GetThrowCount());
    Console.WriteLine("Ball 2 Throws: " + ball2.GetThrowCount());
    Console.WriteLine("Ball 3 Throws: " + ball3.GetThrowCount());

    ball1.Pop();
    ball1.Throw();
    Console.WriteLine("Ball 1 Throws after Pop: " + ball1.GetThrowCount());
  }
  public void Pop()
  {
    Size = 0;
    isPopped = true;
  }

  public void Throw()
  {
    if (!isPopped)
    {
      throwCount++;
    }
  }

  public int GetThrowCount()
  {
    return throwCount;
  }
}

