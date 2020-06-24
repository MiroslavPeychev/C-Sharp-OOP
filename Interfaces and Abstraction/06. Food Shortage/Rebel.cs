namespace P07.FoodShortage
{
    public class Rebel : IBuyer
    {
        private int age;
        private string group;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.age = age;
            this.group = group;
        }

        public string Name { get; private set; }

        public int Food { get; private set; }

        public void ByFood()
        {
            this.Food += 5;
        }
    }
}