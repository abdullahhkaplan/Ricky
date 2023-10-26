using Core.Entities;

namespace Entities.Concrete.Dto
{
    public class PageDto<T> : IDto
    {
        public PageInfoDto Info { get; set; }
        public IEnumerable<T> Results { get; set; }
    }

}
