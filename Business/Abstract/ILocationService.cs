using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILocationService
    {
        IDataResult<List<Location>> GetAll();
        IDataResult<List<Location>> GetById(int id);
        IDataResult<List<Location>> GetMultipleById(int[] id);


        IDataResult<Location> GetByName(string name);
       

        IDataResult<Location> GetByType(string type);
        IDataResult<Location> GetByDimension(string dimension);

    }
}
