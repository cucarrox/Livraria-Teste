using Livraria.Services;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    public class AutorController : Controller
    {

        private readonly ApplicationDbContext _context;

        public AutorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public string Index()
        {

            var autores = _context.Autores.ToList();

            string autoresReturn = "";

            foreach (var autor in autores)
            {
                autoresReturn += $"Id: {autor.Id} | Nome: {autor.Nome} | Nascimento: {autor.Nascimento} | Nacionalidade: {autor.Nacionalidade}\n\n";
            }

            return autoresReturn;
        }
    }
}
