namespace P06.BirthdayCelebrations
{
    public class Citizen : IIndentification, IBirthable
    {
        private string name;
        private int age;
        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Id { get; }

        public string Birthdate { get; }
    }
}