using System.Diagnostics;
using Calidad20222.web.Helper;
using Microsoft.AspNetCore.Mvc;
using Calidad20222.web.Models;
using Calidad20222.web.Services;

namespace Calidad20222.web.Controllers;

public class HomeController : Controller
{
    //private readonly ILogger<HomeController> _logger;

    public HomeController()
    {
       
    }

    /*public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }*/

    [HttpGet]
    public IActionResult Index()
    {
        return View(new List<Carta>());
    }
    
   [HttpPost]
    public IActionResult Generar()
    {
        var service = new PokerService();
        var cartas = GeneradorMano.Generar();
        ViewBag.Jugada = service.GetJugada(cartas);
        return View("Index", cartas);
    }

    [HttpPost]
    public IActionResult Generar_1
        (String Primera, String Segunda, String Tercera, 
        String Cuarta, String Quinta, String Sexta, 
        String PrimerPalo, String SegundoPalo, String TercerPalo, 
        String CuartoPPalo, String QuintoPalo)
    {
        List<Carta> lista = new List<Carta>()
        {
            new Carta
            {
                Numero = int.Parse(Primera),
                Palo = PrimerPalo
            },
            new Carta
            {
                Numero = int.Parse(Segunda),
                Palo = SegundoPalo
            },
            new Carta
            {
                Numero = int.Parse(Tercera),
                Palo = TercerPalo
            },
            new Carta
            {
                Numero = int.Parse(Cuarta),
                Palo =CuartoPPalo
            },
            new Carta
            {
                Numero = int.Parse(Quinta),
                Palo = QuintoPalo
            }
        };
        var service = new PokerService();
        //var cartas = GeneradorMano.Generar();
        ViewBag.Jugada = service.GetJugada(lista);
        return View("Index", lista);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}