using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Model
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public int Color { get; set; }
        public int Icon { get; set; }
        public virtual User? User { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
