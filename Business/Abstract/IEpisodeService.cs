using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEpisodeService
    {
        IDataResult<List<Episode>> GetAll();
        IDataResult<List<Episode>> GetById(int id);
        IDataResult<List<Episode>> GetMultipleById(int[] id);


        IDataResult<Episode> GetByName(string name);
        IDataResult<Episode> Episode(string episode);
        
    }
}
