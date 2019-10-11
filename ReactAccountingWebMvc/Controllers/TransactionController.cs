using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactAccountingWebMvc.Domain.Models;
using ReactAccountingWebMvc.Infrastructure;
using ReactAccountingWebMvc.Web.Models;

namespace ReactAccountingWebMvc.Controllers
{
    public class TransactionController : Controller
    {
        ITransactionService transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
        }

        public IActionResult Index()
        {
            ViewBag.Transactions = transactionService.All();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Transaction transaction)
        {
            var AccountId = transactionService.AllAccounts().Where(a => a.Name == transaction.ToAccountName);
            foreach (var acc in AccountId)
            {
                transaction.ToAccountId = acc.Id;
            }
            transaction.FromAccountId = transaction.AccountId;
            transactionService.Add(transaction);
            return RedirectToAction("add");
        }

        [HttpGet]
        public IActionResult Add(Guid id)
        {
            var transaction = new Transaction() { AccountId = id };
            var AccountName = transactionService.AllAccounts().Where(a => a.Id == transaction.AccountId);
            foreach (var acc in AccountName)
            {
                transaction.FromAccountName = acc.Name;
            }
            ViewBag.ToAccounts = transactionService.AllAccounts().Where(a => a.Name != transaction.FromAccountName);
            return View(transaction);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
