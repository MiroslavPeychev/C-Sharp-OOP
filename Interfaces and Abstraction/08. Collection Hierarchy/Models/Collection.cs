namespace P09.CollectionHierarchy.Models
{
    using P09.CollectionHierarchy.Interfaces;
    using System.Collections.Generic;

    public abstract class Collection : IAdd
    {
        private List<string> list;

        public Collection()
        {
            this.List = new List<string>();
        }

        protected List<string> List { get; }

        public abstract int Add(string item);
    }
}