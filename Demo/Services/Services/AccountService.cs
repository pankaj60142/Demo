using Demo.Services.Repository;
using Demo.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class AccountService:IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public Task<IEnumerable<Account>> GetAllAccounts() {
            return _accountRepository.GetAllAccounts();
        }
        public ValueTask<Account> GetAccount(string searchInput)
        {
            return _accountRepository.GetAccount(searchInput);
        }
        public Task UpdateAccountNameBySnam(string newAccountName, string snam)
        {
            return _accountRepository.UpdateAccountNameBySnam(newAccountName, snam);
;       }
    }
}
