using Demo.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Demo.Controllers
{
    [ApiController]
    [Route("/[Controller]")]
    public class AccountsController : ControllerBase
    {

        private readonly ILogger<AccountsController> _logger;
        private readonly IAccountRepository _accountRepository;

        public AccountsController(ILogger<AccountsController> logger, IAccountRepository accountRepository)
        {
            _logger = logger;
            _accountRepository = accountRepository;
        }

        [HttpGet]
        [Route("GetAllAccounts")]
        public async Task<ActionResult<Accounts>> GetAllAccounts()
        {
            var accounts = await _accountRepository.GetAllAccounts();
            return Ok(accounts);
          
        }
        [HttpGet]
        [Route("GetAccount")]
        public Accounts GetAccount(string SearchParameter)
        {
            return new Accounts() { AccountID = 1, AccountName = "Demo", Snam = "SnamDemo" };
        }
        [HttpPost]
        [Route("UpdateAccount")]
        public Accounts UpdateAccount()
        {
            return new Accounts() { AccountID = 1, AccountName = "Demo", Snam = "SnamDemo" };
        }



    }
}
