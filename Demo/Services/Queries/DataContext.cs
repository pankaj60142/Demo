using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services.Queries
{
    public class DataContext : IDataContext
    {
        public string GetAllAccounts => "SELECT [AccountID], [AccountName], [Snam] FROM [dbo].[ACCOUNTS]";

        public string GetAccount => throw new NotImplementedException();

        public string UpdateAccountNameBySnam => "UPDATE [ACCOUNTS] SET [AccountName] = @AccountName WHERE [Snam] = @Snam ";
    }
}
