using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services.Services
{
    public interface IAccountService
    {
        public Task<IEnumerable<Account>> GetAllAccounts();
        public ValueTask<Account> GetAccount(string searchInput);
        public Task UpdateAccountNameBySnam(string newAccountName, string snam);
    }
}
