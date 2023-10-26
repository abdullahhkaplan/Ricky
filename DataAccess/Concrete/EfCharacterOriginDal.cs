using Core.DataAccess.EF;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfCharacterOriginDal : EfEntityRepositoryBase<CharacterOrigin, RickContext>, ICharacterOriginDal
    {

    }
}
