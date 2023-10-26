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
    public class EpisodeManager : IEpisodeService
    {
        IEpisodeDal _episodeDal;
        public EpisodeManager(IEpisodeDal episodeDal)
        {
            _episodeDal = episodeDal;
        }
        public IDataResult<Episode> Episode(string episode)
        {
            return new SuccessDataResult<Episode>(episode);
        }

        public IDataResult<List<Episode>> GetAll()
        {
            return new SuccessDataResult<List<Episode>>();
        }

        public IDataResult<Episode>GetById(int id)
        {
            return new SuccessDataResult<Episode>(_episodeDal.Get(e=>e.Id==id));
        }

        public IDataResult<Episode> GetByName(string name)
        {
            return new SuccessDataResult<Episode>(_episodeDal.Get(e => e.Name == name));
        }

        public IDataResult<List<Episode>> GetMultipleById(int[] id)
        {
            throw new NotImplementedException();
        }
    }
}
