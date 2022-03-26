using Microsoft.AspNetCore.Mvc;
using Modulo.Models;
using System.Diagnostics;

namespace Modulo.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context contexto)
        {
            _context = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Promocao()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: Consultas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Consulta,Origem,Destino,Entrada,Saida")] Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consulta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consulta);
        }

        // POST: Reservas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Reserva,Nome,CPF,Celular,Email,Origem,Destino,Entrada,Saida")] Reservas reservas)
        {
          
                _context.Add(reservas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}