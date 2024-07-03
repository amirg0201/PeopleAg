using SQLite;
using System.ComponentModel.DataAnnotations.Schema;
using TableAttribute = SQLite.TableAttribute;


namespace People.Models
{
    [Table("AgPeople")]
    public class PersonAg
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250), Unique]
        public string NameAg { get; set; }
    }
}
