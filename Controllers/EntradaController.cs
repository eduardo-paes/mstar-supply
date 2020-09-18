using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using MStartSupply.Models;
using MStartSupply.Data;

namespace MStartSupply.Controllers
{
    public class EntradaController : Controller
    {

        private readonly MStartSupplyContext _context;

        public EntradaController(MStartSupplyContext context)
        {
            _context = context;
        }

        // =====================================================================
        // GET: Detalhes
        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrada = await _context.Entrada
                .FirstOrDefaultAsync(m => m.EntradaID == id);
            if (entrada == null)
            {
                return NotFound();
            }

            return View(entrada);
        }

        // =====================================================================
        // GET: Listagem
        public async Task<ActionResult> Index()
        {
            //string query = "SELECT m.Nome, e.EntradaID, e.Quantidade, e.DataEntrada, e.LocalEntrada, " +
            //    "FROM Entrada AS e, Mercadoria AS m " +
            //    "WHERE e.MercadoriaID = m.MercadoriaID";

            //var result = _context.Database.SqlQuery<Entrada>(query);

            //return View(result.ToList());

            //var query = from e in _context.Entrada
            //            join m in _context.Mercadoria on e.MercadoriaID equals m.MercadoriaID into mercadoria
            //            from m in mercadoria.DefaultItEmpty()
            //            select new { e, m };

            //Console.Write(query);

            return View(await _context.Entrada.ToListAsync());
        }

        // =====================================================================
        // GET: Inserção
        public async Task<IActionResult> InserirAsync()
        {
            ViewData["Mercadoria"] = await _context.Mercadoria.ToListAsync();

            return View();
        }

        // POST: Inserção
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Inserir(
            [Bind("EntradaID,Quantidade,DataEntrada,LocalEntrada,MercadoriaID")] Entrada entrada)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entrada);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(entrada);
        }

        // =====================================================================
        // GET: Edição
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrada = await _context.Entrada.FindAsync(id);
            if (entrada == null)
            {
                return NotFound();
            }
            return View(entrada);
        }

        // POST: Edição
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("EntradaID,Quantidade,DataEntrada,LocalEntrada,MercadoriaID")] Entrada entrada)
        {
            if (id != entrada.EntradaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entrada);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (entrada.EntradaID < 1)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(entrada);
        }

        // =====================================================================
        // GET: Remover
        public async Task<IActionResult> Remover(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrada = await _context.Entrada
                .FirstOrDefaultAsync(m => m.EntradaID == id);
            if (entrada == null)
            {
                return NotFound();
            }

            return View(entrada);
        }

        // POST: Remover
        [HttpPost, ActionName("Remover")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoverConfirmed(int id)
        {
            var entrada = await _context.Entrada.FindAsync(id);
            _context.Entrada.Remove(entrada);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
