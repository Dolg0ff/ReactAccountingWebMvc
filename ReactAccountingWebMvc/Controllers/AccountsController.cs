using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReactAccountingWebMvc.Domain;
using ReactAccountingWebMvc.Domain.Models;
using ReactAccountingWebMvc.Infrastructure.Interfaces;

namespace ReactAccountingWebMvc.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        IAccountService accountService;
        public AccountsController(IAccountService accountSevice,
            UserManager<ApplicationUser> userManager)
        {
            this.accountService = accountSevice;
            _userManager = userManager;
        }

        // GET api/accounts
        [HttpGet]
        public IEnumerable<Account> Get() 
        {
            return accountService.All();
        }

        //POST api/accounts/add
       [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody]Account account)
        {
            ApplicationUser user = await this._userManager.GetUserAsync(HttpContext.User);
            //SignInManager.AuthenticationManager.AuthenticationResponseGrant.Identity.GetUserId();

            //account.UserId = "8d330a12-43ae-4b14-b93b-a2b12cb6feda";
            account.UserId = user.Id;
            account.Id = Guid.NewGuid();
            accountService.Add(account);
            return Ok(account);
        }

        //[HttpPost("add")]
        //public IActionResult Add([FromBody]Account account)
        //{
        //    account.Id = Guid.NewGuid();
        //    accountService.Add(account);
        //    return Ok(account);
        //}

        // PUT api/accounts
        [HttpPut("{id}")]
        public IActionResult Update(Guid id)
        {
            var account = accountService.Find(id);
            return Ok(account);
        }

        // DELETE api/accounts
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            accountService.Delete(id);
        }

        // GET api/accounts
        [HttpGet("{id}")]
        public IActionResult Details(Guid id)
        {
            var account = accountService.Find(id);
            return new ObjectResult(account);
        }
    }
}

