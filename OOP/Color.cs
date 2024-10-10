namespace OOP;
public class Color(int red, int green, int blue, int alpha)
{
  // Instance variables
  public int Red { get; set; } = red;
  public int Green { get; set; } = green;
  public int Blue { get; set; } = blue;
  public int Alpha { get; set; } = alpha;

  public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

  public int GetGrayscaleValue()
  {
    return (Red + Green + Blue) / 3;
  }
}
