using AutoMapper;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RickAndMortyMapper : IRickAndMortyMapper
    {
        public IMapper Mapper { get; set; }
    }
}
