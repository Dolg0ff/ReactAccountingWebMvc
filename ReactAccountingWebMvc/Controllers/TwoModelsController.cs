using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactAccountingWebMvc.Infrastructure;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactAccountingWebMvc.Controllers
{
    public class TwoModelsController : Controller
    {
        ITwoModelsService twoModelsService;
        public TwoModelsController(ITwoModelsService twoModelsService)
        {
            this.twoModelsService = twoModelsService;
        }

        public IActionResult Index()
        {
            ViewBag.AccountsIn = twoModelsService.AllAccounts().Where(a => a.Type == Domain.Enums.AccountType.Income);
            ViewBag.AccountsOut = twoModelsService.AllAccounts().Where(a => a.Type == Domain.Enums.AccountType.Outcome);
            ViewBag.TransactionsIn = twoModelsService.AllTransactions().Where(a => a.Type == Domain.Enums.TransactionType.Income);
            ViewBag.TransactionsOut = twoModelsService.AllTransactions().Where(a => a.Type == Domain.Enums.TransactionType.Outcome);
            return View();
        }
    }
}
