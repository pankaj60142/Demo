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
        public async Task<IEnumerable<Accounts>> GetAllAccounts()
        {
            return await WithConnection( async conn => 
            { 
                var query = await conn.QueryAsync<Accounts>(_dataContext.GetAllAccounts); 
                return query; 
            });
        }
    }
}
