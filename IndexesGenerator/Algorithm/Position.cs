namespace IndexesGenerator.Algorithm
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(Position left, Position right) =>
            right != null && left != null && left.X == right.X && left.Y == right.Y;

        public static bool operator !=(Position left, Position right) =>
            right != null && left != null && left.X != right.X && left.Y != right.Y;

        public static bool operator <(Position left, Position right) =>
            left.X < right.X || left.Y < right.Y;

        public static bool operator >(Position left, Position right) =>
            left.X > right.X || left.Y > right.Y;

        public static bool operator <=(Position left, Position right) =>
            left.X <= right.X || left.Y <= right.Y;

        public static bool operator >=(Position left, Position right) =>
            left.X >= right.X || left.Y >= right.Y;

        public override bool Equals(object target)
        {
            if (ReferenceEquals(this, target))
            {
                return true;
            }

            if (ReferenceEquals(target, null))
            {
                return false;
            }

            if (target is Position)
            {
                var casted = target as Position;

                return X == casted.X && Y == casted.Y;
            }

            return false;
        }

        public override int GetHashCode() =>
            X.GetHashCode() ^ Y.GetHashCode();

        public override string ToString() =>
            $"({X}, {Y})";
    }
}
