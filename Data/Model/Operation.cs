namespace Data.Model
{
    public class Operation : BaseModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Entry { get; set; }
        public DateOnly Date { get; set; }
        public virtual Category? Category { get; set; }
        public virtual User? User { get; set; }


    }
}
