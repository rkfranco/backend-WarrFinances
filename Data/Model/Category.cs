using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Data.Model
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public int Color { get; set; }
        public int Icon { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [JsonIgnore]
        public virtual User? User { get; set; }

    }
}
