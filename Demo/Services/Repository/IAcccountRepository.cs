using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services.Repository
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Accounts>> GetAllAccounts();
    }
}
