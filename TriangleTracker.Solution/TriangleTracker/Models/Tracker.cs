namespace Tracker.Models
{
  public class Triangle
  {
    //Public class properties
    public int Side1 { get; set; }
    public int Side2 { get; set; }
    public int Side3 { get; set; }
    public string Type { get; set;}

    //Constructor: Assigns values to properties
    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
      Type = "";
    }

    public void CheckType()
    {
      if (this.Side1 + this.Side2 <= this.Side3 || this.Side1 + this.Side3 <= this.Side2 || this.Side2 + this.Side3 <= this.Side1) {
        this.Type = "Not a triangle";
      }
    }
  }
}