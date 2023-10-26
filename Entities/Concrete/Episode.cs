using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Episode:IEntity
    {
        

       
        public int Id { get; set; }

        
        public string Name { get; set; }

       
        public DateTime? AirDate { get; set; }

       
        public string EpisodeCode { get; set; }

        
        public IEnumerable<Uri> Characters { get; set; }

        
        public Uri Url { get; set; }

       
        public DateTime? Created { get;  }
    }
}
