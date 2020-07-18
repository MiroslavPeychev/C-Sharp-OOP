namespace P06.GenericCountMethodDouble
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T> where T : IComparable
    {
        public Box(List<T> value)
        {
            this.Values = value;
        }

        public List<T> Values { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Values)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

        public void Swap(List<T> items, int firstIndex, int secondIndex)
        {
            T tempValue = items[firstIndex];

            items[firstIndex] = items[secondIndex];
            items[secondIndex] = tempValue;
        }

        public int CountGreaterElements(List<T> elements, T elementToCompare)
        {
            int biggerElementsCount = 0;
            
            foreach (var element in elements)
            {
                if (elementToCompare.CompareTo(element) < 0)
                {
                    biggerElementsCount++;
                }
            }

            return biggerElementsCount;
        }
    }
}