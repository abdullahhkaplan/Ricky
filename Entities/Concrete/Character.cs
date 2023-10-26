using Core.Entities;
using Entities.Concrete.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Character:IEntity
    {
      
        public int Id { get; set; }
       

        public string Name { get; set; }

        
        public string Status { get; set; }

        
        public string Species { get; set; }

        public string Type { get; set; }

     
        public string Gender { get; set; }

        
        public CharacterLocation Location { get; set; }

        
        public CharacterOrigin Origin { get; set; }

        
        public Uri Image { get; set; }

       
        public IEnumerable<Uri> Episode { get; set; }

       
        public Uri Url { get; set; }

        public DateTime? Created { get; set; }
    }
}

