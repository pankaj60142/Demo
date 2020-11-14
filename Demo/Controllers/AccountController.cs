using Demo.Services.Helper;
using Demo.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;


namespace Demo.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AccountController : ControllerBase
    {

        private readonly ILogger<AccountController> _logger;
        private readonly IAccountRepository _accountRepository;
        private readonly IHelper _helper;

        public AccountController(ILogger<AccountController> logger, IAccountRepository accountRepository, IHelper helper)
        {
            _logger = logger;
            _accountRepository = accountRepository;
            _helper = helper;
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
            var account = await _accountRepository.GetAccount(_helper.ValidateInput(searchParameter));
            return Ok(account);
        }
        [HttpPut]
        [Route("UpdateAccount")]
        public async Task<ActionResult<Account>> UpdateAccount(string newAccountName, string snam)
        {
            //  Validate Inputs
            var validNewAccountName = _helper.ValidateInput(newAccountName);
            var validsnam = _helper.ValidateInput(snam);

            // Check for Empty Input
            if (!string.IsNullOrEmpty(newAccountName) && !string.IsNullOrEmpty(snam))
            {
                var account = await _accountRepository.GetAccount(validsnam);
                if (!string.Equals(_helper.ValidateInput(account.AccountName),validNewAccountName))
                {
                    await _accountRepository.UpdateAccountNameBySnam(validNewAccountName, snam);
                    return Ok();
                }               
            }
            return NoContent();
        }
    }
}
