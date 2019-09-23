using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ReactAccountingWebMvc.Infrastructure.Interfaces;
using ReactAccountingWebMvc.Domain;
using ReactAccountingWebMvc.Models;
using ReactAccountingWebMvc.Web.Models;

namespace Accounting.Web.Controllers
{
    public class HomeController : Controller
    {
        IAccountService accountService;
        public HomeController(IAccountService accountSevice)
        {
            this.accountService = accountSevice;
        }

        [HttpPost]
        public IActionResult Add(Account account)
        {
            accountService.Add(account);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Add(String id)
        {
            var account = new Account() { UserId = id };
            return View(account);
        }

        [HttpPost]
        public IActionResult Update(Account account)
        {
            accountService.Update(account);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            accountService.Delete(id);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Update(Guid id)
        {
            var account = accountService.Find(id);
            return View(account);
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var account = accountService.Find(id);
            return View(account);
        }

        public IActionResult Index()
        {
            var accounts = accountService.All();
            return View(accounts);
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
