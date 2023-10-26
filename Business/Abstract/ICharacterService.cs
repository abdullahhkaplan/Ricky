using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICharacterService
    {
        IDataResult<List<Character>> GetAll();
        IDataResult<List<Character>> GetById(int id);
        


        IDataResult<Character> GetByName(string name);
        IDataResult<Character> GetByStatus(string status);
        IDataResult<Character> GetBySpecies(string species);

        IDataResult<Character> GetByType(string type);
        IDataResult<Character> GetByGender(string gender);
       


    }
}
