using Core.DataAccess.EF;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfLocationDal : EfEntityRepositoryBase<Location, RickContext>, ILocationDal
    {

    }
}
