using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services.Queries
{
    public interface IDataContext
    {
        string GetAllAccounts { get; }
        string GetAccount { get; }
        string UpdateAccountNameBySnam { get; }
    }
}
