using System;

namespace ClassPractice2
{
  class Program
  {
    static void Main(string[] args)
    {
      _2DPoint p1 = new _2DPoint(2, 4);
      _3DPoint p2 = new _3DPoint(3, 5, 4);
      _2DPoint p3 = new _2DPoint(2, 4);

      Console.WriteLine("Is p1 equal to p3 {0}", p1.Equals(p3));

      Console.WriteLine("p1 = {0}", p1);
      Console.WriteLine("p3 = {0}", p3);
    }
  }
  public class _2DPoint
  {
    public int x;
    public int y;
    public _2DPoint(int h, int v)
    {
      this.x = h;
      this.y = v;
    }
    override
    public String ToString()
    {
      String s = String.Format("({0}, {1})", x, y);
      return s;
    }
  }
  public class _3DPoint : _2DPoint
  {
    public int z;
    public _3DPoint(int h, int v, int d) : base(h, v)
    {
      this.z = d;
    }
    override
    public String ToString()
    {
      String s = String.Format("({0}, {1}, {2})", x, y, z);
      return s;
    }
  }
}
