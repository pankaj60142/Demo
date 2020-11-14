using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services.Queries
{
    public class DataContext : IDataContext
    {
        public string GetAllAccounts => "SELECT [AccountID], [AccountName], [Snam] FROM [dbo].[ACCOUNTS]";

        public string GetAccount => "SELECT [AccountID], [AccountName], [Snam] FROM [dbo].[ACCOUNTS] Where AccountID LIKE @SearchInput  OR AccountName Like @SearchInput   OR Snam Like @SearchInput";

        public string UpdateAccountNameBySnam => "UPDATE [ACCOUNTS] SET [AccountName] = @NewAccountName WHERE [Snam] = @Snam ";
    }
}
