namespace GenericScale
{
    using System;

    public class EqualityScale<T>
        where T : IComparable<T>
    {
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public T GetHeavier()
        {
            int comparison = left.CompareTo(right);

            if (comparison == 1)
            {
                return left;
            }
            else if (comparison == -1)
            {
                return right;
            }

            return default(T);

        }
    }
}