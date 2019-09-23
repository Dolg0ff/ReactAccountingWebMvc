using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactAccountingWebMvc.Domain;
using ReactAccountingWebMvc.Infrastructure.Interfaces;

namespace ReactAccountingWebMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        IAccountService accountService;
        public AccountsController(IAccountService accountSevice)
        {
            this.accountService = accountSevice;
        }

        // GET api/accounts
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return accountService.All();
        }

        // POST api/accounts
        [HttpPost]
        public void Add(Account account)
        {
            accountService.Add(account);
        }

        // GET api/accounts
        //[HttpGet]
        //public IActionResult Add(String id)
        //{
        //    var account = new Account() { UserId = id };
        //    return Ok(account);
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Update(Guid id)
        {
            var account = accountService.Find(id);
            return Ok(account);
        }

        // DELETE api/accounts/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            accountService.Delete(id);
        }

        // GET api/accounts/5
        [HttpGet("{id}")]
        public IActionResult Details(Guid id)
        {
            var account = accountService.Find(id);
            return new ObjectResult(account);
        }
    }
}

