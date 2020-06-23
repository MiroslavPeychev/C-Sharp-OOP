namespace P05.BorderControl
{
    public class Citizen : IIndentification
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
        }

        public string Id { get; }
    }
}