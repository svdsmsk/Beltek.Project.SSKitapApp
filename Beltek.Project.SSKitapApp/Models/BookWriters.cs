using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beltek.Project.SSKitapApp.Models
{
    [Table("tblWriters")]
    public class BookWriters
    {
        public int Id { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public DateTime DateTime { get; set; }    

    }
}
