using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LocationManager : ILocationService
    {
        ILocationDal _locationDal;
        public LocationManager(ILocationDal locationDal)

        {
            _locationDal = locationDal;
            
        }
        public IDataResult<List<Location>> GetAll()
        {
            return new SuccessDataResult<List<Location>>();
        }

        public IDataResult<Location> GetByDimension(string dimension)
        {
           return new SuccessDataResult<Location>(_locationDal.Get(l=>l.Dimension==dimension));
        }

        public IDataResult<Location> GetById(int id)
        {
            return new SuccessDataResult<Location>(_locationDal.Get(l => l.Id == id));
        }

        public IDataResult<Location> GetByName(string name)
        {
            return new SuccessDataResult<Location>(_locationDal.Get(l => l.Name == name));
        }

        public IDataResult<Location> GetByType(string type)
        {
            return new SuccessDataResult<Location>(_locationDal.Get(l => l.Type == type));
        }

        public IDataResult<List<Location>> GetMultipleById(int[] id)
        {
            throw new NotImplementedException();
        }
    }
}
