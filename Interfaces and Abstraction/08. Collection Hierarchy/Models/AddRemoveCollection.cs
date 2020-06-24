using P09.CollectionHierarchy.Interfaces;

namespace P09.CollectionHierarchy.Models
{
    public class AddRemoveCollection : Collection, IRemove
    {
        public AddRemoveCollection()
            : base()
        {
        }

        public override int Add(string element)
        {
            this.List.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string item = this.List[this.List.Count - 1];
            this.List.RemoveAt(this.List.Count - 1);
            return item; 
        }
    }
}