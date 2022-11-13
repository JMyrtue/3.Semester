using static System.Math;

public class Circle
{
    double Radius { get; set; }
    Point Center;

    public Circle(double radius, int x, int y)
    {
        Radius = radius;
        Center = new Point(x, y);
    }

    private double DistanceToPoint(Point p)
    {
        return Sqrt(Pow(Center.X - p.X, 2) + Pow(Center.Y - p.Y, 2));
    }
    public bool ContainsPoint(Point p)
    {
        double distanceToPoint = DistanceToPoint(p);
        if (distanceToPoint < Radius)
            return true;
        else
            return false;
    }

    public bool CircleOverlap(Circle c)
    {
        double centerDistance = DistanceToPoint(c.Center);

        if (centerDistance < Radius + c.Radius)
            return true;
        else
            return false;
    }
        
}
