using System.ComponentModel.DataAnnotations.Schema;

namespace Beltek.Project.SSKitapApp.Models
{
    [Table("tblStationary")]
    public class Stationary
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int ProductPrice { get; set; }
    }
}
