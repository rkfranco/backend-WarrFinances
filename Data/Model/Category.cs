namespace Data.Model
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public int Color { get; set; }
        public int Icon { get; set; }
        public User User { get; set; }
    }
}
