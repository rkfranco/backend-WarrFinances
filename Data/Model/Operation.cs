namespace Data.Model
{
    public class Operation : BaseModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Entry { get; set; }
        public DateOnly Date { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }


    }
}
