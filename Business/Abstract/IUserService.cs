using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult AddUser(User user);
        IDataResult<User> GetByMail(string email); // daha önce bir kullanıcı olup olmadığını tespit etmek için gerekli iş kodu => çözmem gerek :(

        IDataResult<List<OperationClaim>> GetClaims(User user);
    }
}
