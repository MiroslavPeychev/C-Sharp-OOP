namespace P09.CollectionHierarchy.Models
{
    public class AddCollection : Collection
    {
        public AddCollection()
            : base()
        {
        }

        public override int Add(string element)
        {
            this.List.Add(element);
            int itemIndex = this.List.Count - 1;
            return itemIndex;
        }
    }
}