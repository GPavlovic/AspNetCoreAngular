using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreAngular.Models
{
    [Table("Features")]
    public class Feature
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        [Required]
        [StringLengthAttribute(255)]
        public string Name { get; set; }
    }
}