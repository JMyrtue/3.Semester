public class Vector2D
{
    public int R1 { get; set; }
    public int R2 { get; set; }

    public Vector2D(int r1, int r2)
    {
        R1 = r1;
        R2 = r2;
    }

    public Vector2D Add(Vector2D otherV)
    {
        return new Vector2D(R1 + otherV.R1, R2 + otherV.R2);

    }

    public Vector2D Subtract(Vector2D otherV)
    {
        return new Vector2D(R1 - otherV.R1, R2 - otherV.R2);
    }

    public int Scalar(Vector2D otherV)
    {
        return R1 * otherV.R1 + R2 * otherV.R2;
    }

    public int CrossProduct(Vector2D otherV)
    {
        return R1 * otherV.R2 + R2 * otherV.R1;
    }

    public bool Equals(Vector2D other)
    {
        if (R1 == other.R1 && R2 == other.R2)
            return true;
        return false;
    }
}