using Livraria.Models;
using Livraria.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Livraria.Controllers
{
    public class EditoraController : Controller
    {

        private readonly ApplicationDbContext _context;

        public EditoraController(ApplicationDbContext context)
        {
            _context = context;
        }

        public string Index()
        {
            var editoras = _context.Editoras.ToList();

            string editorasReturn = "";

            foreach (var editora in editoras)
            {
                editorasReturn += $"Id: {editora.Id} | Nome: {editora.Nome} | Endereço: {editora.Endereco} | CNPJ: {editora.CNPJ}\n\n";
            }

            return editorasReturn;
        }
    
        public string Adicionar(string nome, string endereco, string cnpj)
        {
            Console.WriteLine(nome);
            Console.WriteLine(endereco);
            Console.WriteLine(cnpj);

            Editora novaEditora = new Editora();
            novaEditora.Nome = nome;
            novaEditora.Endereco = endereco;
            novaEditora.CNPJ = cnpj;

            // Verificar validação do modelo

            var resultadoAdd = _context.Add(novaEditora);
            _context.SaveChanges();

            return resultadoAdd.IsKeySet.ToString();
        }
    }
}
