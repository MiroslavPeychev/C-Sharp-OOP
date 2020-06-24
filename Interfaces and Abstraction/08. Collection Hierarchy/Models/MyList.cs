using P09.CollectionHierarchy.Interfaces;

namespace P09.CollectionHierarchy.Models
{
    public class MyList : Collection, IRemove, IUsed
    {
        public MyList()
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
            string element = this.List[0];
            this.List.RemoveAt(0);
            return element;
        }

        public int Used()
        {
            return this.List.Count;
        }
    }
}