namespace Data.Model
{
    public class Operation : BaseModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Entry { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }

    }
}
