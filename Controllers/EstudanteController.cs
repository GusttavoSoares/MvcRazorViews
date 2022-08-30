using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    // private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel> ();
    // static - uma coleção só para a aplicação toda

    private static List<EstudanteViewModel> estudantes = 
    new List<EstudanteViewModel> {
        new EstudanteViewModel(1, "Magali Silva", "Rua X, 1", true),
        new EstudanteViewModel(2, "Cebolinha dos Santos", "Rua Y, 2", true),
        new EstudanteViewModel(3, "Chico Bento", "Rua Z, 3", false),
        new EstudanteViewModel(4, "Monica Pereira", "Rua M, 4", true),
    };

    public IActionResult Index() 
    {
        return View(estudantes);
    }

    public IActionResult Show(int id) 
    {
        return View(estudantes[id - 1]);
    }
}