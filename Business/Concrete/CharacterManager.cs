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
    public class CharacterManager : ICharacterService
    {
        ICharacterDal _characterDal;
        IEpisodeService _episodeService;
        public CharacterManager (ICharacterDal characterDal, IEpisodeService episodeService)
        {
            _characterDal=characterDal; _episodeService=episodeService;
        }

        public IDataResult<List<Character>> GetAll()
        {
            return new SuccessDataResult<List<Character>>(_characterDal.GetAll());
        }

        public IDataResult<Character> GetByGender(string gender)
        {
            return new SuccessDataResult<Character>(_characterDal.Get(c=>c.Gender==gender));
        }

        public IDataResult<Character> GetById(int id)
        {
            return new SuccessDataResult<Character>(_characterDal.Get(c=>c.Id==id));

        }

        public IDataResult<Character> GetByName(string name)
        {
            return new SuccessDataResult<Character>(_characterDal.Get(c => c.Name == name));
        }

        public IDataResult<Character> GetBySpecies(string species)
        {
            return new SuccessDataResult<Character>(_characterDal.Get(c => c.Species == species));
        }

        public IDataResult<Character> GetByStatus(string status)
        {
            return new SuccessDataResult<Character>(_characterDal.Get(c => c.Status == status));
        }

        public IDataResult<Character> GetByType(string type)
        {
            return new SuccessDataResult<Character>(_characterDal.Get(c => c.Type == type));
        }

       
    }
}
