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
        [HttpPost("add")]
        public IActionResult Add([FromBody]Account account)
        {
            account.UserId = "8d330a12-43ae-4b14-b93b-a2b12cb6feda";
            account.Id = Guid.NewGuid();
            accountService.Add(account);
            return Ok(account);
        }

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

