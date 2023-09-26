using ASPNetMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetMVC.Controllers;

public class HomeController : Controller
{
    [HttpPost]
    [HttpGet]
    public IActionResult Index(HomeModel form)
    {
        CarregarListaDeDados();
        return View();
    }
    public void CarregarListaDeDados()
    {
        HomeModel homeModel = new HomeModel();
        // ViewBag: Permite trocar infos entra o Controller e a View
        ViewBag.Lista = homeModel.GetAll();
    }
}
