using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace People.Models
{
    [Table("people")]
    public class PersonAg
    {
        [PrimaryKey, AutoIncrement]
        public int AgId { get; set; }

        [MaxLength(250), Unique]
        public string NameAg { get; set; }
    }
}
