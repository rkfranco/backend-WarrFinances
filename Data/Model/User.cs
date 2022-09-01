using System.Text.Json.Serialization;

namespace Data.Model
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
    }
}
