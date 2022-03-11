using AS.AdvertisementApp.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS.AdvertisementApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvidedServiceManager _providedServiceManager;

        public HomeController(IProvidedServiceManager providedServiceManager)
        {
            _providedServiceManager = providedServiceManager;
        }

        public async Task<IActionResult> Index()
        {
            var reponse = await _providedServiceManager.GetAllAsync();
            return View();
        }
    }
}
