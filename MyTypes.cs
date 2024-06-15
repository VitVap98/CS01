namespace MyTypes
{
    namespace Points
    {
        public abstract class PointAbstract
        {
            public abstract double GetMagnitude();
        }

        public class Point2D : PointAbstract
        {
            protected double X = 0;
            protected double Y = 0;
            public Point2D(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }
            public override double GetMagnitude()
            {
                return (double)MathF.Sqrt((float)(this.X * this.X + this.Y * this.Y));
            }
            public override string ToString()
            {
                return $"<{this.X}, {this.Y}>";
            }
        }

        public class Point3D : Point2D
        {
            private double Z = 0;
            public Point3D(double x, double y, double z) : base(x, y)
            {
                this.Z = x;
            }
            public override double GetMagnitude()
            {
                return (double)MathF.Sqrt((float)(this.X * this.X + this.Y * this.Y + this.Z * this.Z));
            }
            public override string ToString()
            {
                return $"<{this.X}, {this.Y}, {this.Z}>";
            }
        }
    }
}