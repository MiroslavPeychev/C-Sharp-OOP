namespace Animals
{
    public class TomCat : Cat
    {
        private const string DEFAULT_GENDER = "Male";
        public TomCat(string name, int age)
            : base(name, age, DEFAULT_GENDER)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}