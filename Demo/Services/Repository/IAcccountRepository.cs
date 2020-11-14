using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services.Repository
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Account>> GetAllAccounts();
        ValueTask<Account> GetAccount(string searchInput);
        Task UpdateAccountNameBySnam(string newAccountName, string snam);
    }
}
