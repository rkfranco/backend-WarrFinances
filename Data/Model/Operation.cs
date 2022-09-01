using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Data.Model
{
    public class Operation : BaseModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Entry { get; set; }
        public DateTime Date { get; set; }


        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }


        public int UserId { get; set; }
        [ForeignKey("UserId")]
        [JsonIgnore]
        public virtual User? User { get; set; }
    }
}
