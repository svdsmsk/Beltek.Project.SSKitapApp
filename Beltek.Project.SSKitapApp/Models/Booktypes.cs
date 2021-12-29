using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beltek.Project.SSKitapApp.Models
{
    [Table("tblBooktypes")]
    public class Booktypes
    {
        public int Id { get; set; }
        public string BookType { get; set; }

        public virtual ICollection<Books> Books { get; set; }

    }
}
