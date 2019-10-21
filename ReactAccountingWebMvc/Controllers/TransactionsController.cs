using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReactAccountingWebMvc.Domain;
using ReactAccountingWebMvc.Domain.Models;
using ReactAccountingWebMvc.Infrastructure;
using ReactAccountingWebMvc.Infrastructure.Interfaces;

namespace ReactAccountingWebMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        ITransactionService transactionService;
        public TransactionsController(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
        }

        // GET api/transactions
        [HttpGet]
        public IEnumerable<Transaction> Get() 
        {
            return transactionService.All();
        }

        // POST api/transactions
        [HttpPost("add")]
        public IActionResult Add([FromBody]Transaction transaction)
        {
            Console.WriteLine(transaction.FromAccountName);
            Console.WriteLine(transaction.ToAccountName);
            transaction.Id = Guid.NewGuid();
            var AccountId = transactionService.AllAccounts().Where(a => a.Name == transaction.ToAccountName);
            foreach (var acc in AccountId)
            {
                transaction.ToAccountId = acc.Id;
            }
            var fromAccountId = transactionService.AllAccounts().Where(a => a.Name == transaction.FromAccountName);
            foreach (var frAcc in fromAccountId)
            {
                transaction.FromAccountId = frAcc.Id;
                transaction.AccountId = frAcc.Id;
            }
            transactionService.Add(transaction);
            return Ok(transaction);
        }

        // PUT api/transactions
        [HttpPut("{id}")]
        public IActionResult Update(Guid id)
        {
            var transaction = new Transaction() { AccountId = id };
            var AccountName = transactionService.AllAccounts().Where(a => a.Id == transaction.AccountId);
            foreach (var acc in AccountName)
            {
                transaction.FromAccountName = acc.Name;
            }
            //ViewBag.ToAccounts = transactionService.AllAccounts().Where(a => a.Name != transaction.FromAccountName);
            return Ok(transaction);
        }
    }
}

