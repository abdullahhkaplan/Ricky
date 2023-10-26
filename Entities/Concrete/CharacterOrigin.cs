using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CharacterOrigin:IEntity
    {
       

       
        public string Name { get; set; }

       
        public Uri Url { get; set; }
    }
}

