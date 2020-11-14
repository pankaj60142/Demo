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
    [Route("[Controller]")]
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
        public async Task<ActionResult<Account>> GetAllAccounts()
        {
            var accounts = await _accountRepository.GetAllAccounts();
            return Ok(accounts);
          
        }
        [HttpGet]
        [Route("GetAccount")]
        public async Task<ActionResult<Account>> GetAccount(string searchParameter)
        {
            var account = await _accountRepository.GetAccount(searchParameter);
            return Ok(account);
        }
        [HttpPut]
        [Route("UpdateAccount")]
        public async Task<ActionResult<Account>> UpdateAccount(string newAccountName, string snam)
        {
            await _accountRepository.UpdateAccountNameBySnam(newAccountName, snam);
            return Ok();
        }



    }
}
