using System;
public abstract class Shape
{
    public abstract void draw();
    public abstract void add();
}
public class Rectangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("drawing rectangle...");
    }

    public override void add()
    {

    }
}
public abstract class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine("drawing circle...");
    }
}

public class Addition:Circle
{
    public override void add()
    {
        Console.WriteLine("Addition Classs");
    }
}
public class TestAbstract
{
    public static void Main()
    {
        Shape s = new Rectangle();
        s.draw();
        Shape c = new Addition();
        c.draw();
        c.add();
    }
}