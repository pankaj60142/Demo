using Dapper;
using Demo.Services.Queries;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services.Repository
{
    public class AccountRepository : BaseRepository, IAccountRepository
    {
        private readonly IDataContext _dataContext;
        public AccountRepository(IConfiguration configuration, IDataContext dataContext):base(configuration)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<Account>> GetAllAccounts()
        {
            return await WithConnection( async conn => 
            { 
                var query = await conn.QueryAsync<Account>(_dataContext.GetAllAccounts); 
                return query; 
            });
        }

        public async Task UpdateAccountNameBySnam(string newAccountName, string snam)
        {
            await WithConnection(async conn =>
           {
               await conn.ExecuteAsync(_dataContext.UpdateAccountNameBySnam, 
                   new {NewAccountName = newAccountName, Snam = snam });
           });
        }

        public async ValueTask<Account> GetAccount(string searchInput)
        {
            return await WithConnection(async conn =>
           {
               var query = await conn.QueryFirstOrDefaultAsync<Account>(_dataContext.GetAccount, new { SearchInput = searchInput });
               return query;
           });
        }
    }
}
