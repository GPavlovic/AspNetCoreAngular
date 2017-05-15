using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreAngular.Models
{
    public class Make
    {
        public int Id { get; set; }
        
        [Required]
        [StringLengthAttribute(255)]
        public string Name { get; set; }

        public ICollection<Model> Models { get; set;}

        Make() {
            Models = new Collection<Model>();
        }
    }
}