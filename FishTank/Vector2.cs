namespace FishTank
{
    public class Vector2
    {
        public double X;
        public double Y;

        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector2 operator +(Vector2 vec1, Vector2 vec2)
        {
            return new Vector2(vec1.X + vec2.X, vec1.Y + vec2.Y);
        }

        public static Vector2 operator *(Vector2 vec, double factor)
        {
            return new Vector2(vec.X * factor, vec.Y * factor);
        }
    }
}