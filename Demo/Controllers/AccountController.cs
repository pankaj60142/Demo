using Demo.Services.Helper;
using Demo.Services.Repository;
using Demo.Services.Services;
using log4net;
using log4net.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;


namespace Demo.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AccountController : ControllerBase
    {

        private readonly ILogger<AccountController> _logger;
        private readonly IAccountService _accountService;
        private readonly IHelper _helper;
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly ILoggerRepository _repository = LogManager.GetRepository(Assembly.GetCallingAssembly());
        private readonly FileInfo fileInfo = new FileInfo(@"log4net.config");
        

        public AccountController(ILogger<AccountController> logger, IAccountService accountService, IHelper helper)
        {
            _logger = logger;
            _accountService = accountService;
            _helper = helper;
        }

        [HttpGet]
        [Route("GetAllAccounts")]
        public async Task<ActionResult<Account>> GetAllAccounts()
        {
            try
            {                
                log4net.Config.XmlConfigurator.Configure(_repository, fileInfo); 
                
                _log.Info("Get All Accounts Action start");
                var accounts = await _accountService.GetAllAccounts();
                _log.Info("Get All Accounts Action finished");

                return Ok(accounts);
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message);
                return NotFound();
            }         
        }
        [HttpGet]
        [Route("GetAccount")]
        public async Task<ActionResult<Account>> GetAccount(string searchParameter)
        {
            try
            {
                if (!string.IsNullOrEmpty(searchParameter))
                {
                    log4net.Config.XmlConfigurator.Configure(_repository, fileInfo);

                    _log.Info("Get Account Action start");
                    var account = await _accountService.GetAccount(_helper.ValidateInput(searchParameter));
                    _log.Info("Get Account Action finished");

                    return Ok(account);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                _log.Error(ex.Message);
                return NotFound();
            }
        }
        [HttpPut]
        [Route("UpdateAccount")]
        public async Task<ActionResult<Account>> UpdateAccount(string newAccountName, string snam)
        {
            try
            {
                if (!string.IsNullOrEmpty(newAccountName) && !string.IsNullOrEmpty(snam))
                {
                    log4net.Config.XmlConfigurator.Configure(_repository, fileInfo);
                    //  Validate Inputs
                    var validNewAccountName = _helper.ValidateInput(newAccountName);
                    var validsnam = _helper.ValidateInput(snam);

                    // Check for Empty Input
                    if (!string.IsNullOrEmpty(newAccountName) && !string.IsNullOrEmpty(snam))
                    {
                        var account = await _accountService.GetAccount(validsnam);
                        if (!string.Equals(_helper.ValidateInput(account.AccountName), validNewAccountName))
                        {
                            _log.Info("Update Account Action start");
                            await _accountService.UpdateAccountNameBySnam(validNewAccountName, snam);
                            _log.Info("Update Account Action finished");

                            return Ok();
                        }
                    }
                    return NoContent();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                _log.Error(ex.Message);
                return NotFound();
            }
        }
    }
}
