using System.ComponentModel.DataAnnotations.Schema;

namespace Beltek.Project.SSKitapApp.Models
{
    [Table("tblBooks")]
    public class Books
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Writer { get; set; }
        public string Name { get; set; }
        public string Printing { get; set; }
        public int Price { get; set; }


    }
}
