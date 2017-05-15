using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreAngular.Controllers.Resources
{
    public class MakeResource
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public ICollection<ModelResource> Models { get; set;}

        MakeResource() {
            Models = new Collection<ModelResource>();
        }
    }
}