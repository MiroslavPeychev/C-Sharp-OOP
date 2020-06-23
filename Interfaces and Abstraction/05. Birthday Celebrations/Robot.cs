namespace P06.BirthdayCelebrations
{
    public class Robot : IIndentification
    {
        private string model;

        public Robot(string model, string id)
        {
            this.model = model;
            this.Id = id;
        }

        public string Id { get; }
    }
}