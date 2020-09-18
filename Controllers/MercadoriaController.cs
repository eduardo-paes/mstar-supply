using System;
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
    public class MercadoriaController : Controller
    {

        private readonly MStartSupplyContext _context;

        public MercadoriaController(MStartSupplyContext context)
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

            var mercadoria = await _context.Mercadoria
                .FirstOrDefaultAsync(m => m.MercadoriaID == id);
            if (mercadoria == null)
            {
                return NotFound();
            }

            return View(mercadoria);
        }

        // =====================================================================
        // GET: Listagem
        public async Task<IActionResult> Index(string mercadoriaTipo, string searchString)
        {
            // LINQ para lista de tipos.
            IQueryable<string> tipoQuery = from m in _context.Mercadoria
                                            orderby m.Tipo
                                            select m.Tipo;

            var mercadorias = from m in _context.Mercadoria
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                mercadorias = mercadorias.Where(s => s.Nome.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(mercadoriaTipo))
            {
                mercadorias = mercadorias.Where(x => x.Tipo == mercadoriaTipo);
            }

            var mercadoriaTipoVM = new MercadoriaTipoViewModel
            {
                Tipos = new SelectList(await tipoQuery.Distinct().ToListAsync()),
                Mercadorias = await mercadorias.ToListAsync()
            };

            return View(mercadoriaTipoVM);
        }

        // POST: Listagem
        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }

        // =====================================================================
        // GET: Inserção
        public IActionResult Inserir()
        {
            return View();
        }

        // POST: Inserção
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Inserir(
            [Bind("MercadoriaID,Nome,NumeroRegistro,Tipo,Fabricante,Quantidade,Descricao")] Mercadoria mercadoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mercadoria);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(mercadoria);
        }

        // =====================================================================
        // GET: Edição
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mercadoria = await _context.Mercadoria.FindAsync(id);
            if (mercadoria == null)
            {
                return NotFound();
            }
            return View(mercadoria);
        }

        // POST: Edição
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("MercadoriaID,Nome,NumeroRegistro,Tipo,Fabricante,Quantidade,Descricao")] Mercadoria mercadoria)
        {
            if (id != mercadoria.MercadoriaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mercadoria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (mercadoria.MercadoriaID < 1)
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
            return View(mercadoria);
        }

        // =====================================================================
        // GET: Remover
        public async Task<IActionResult> Remover(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mercadoria = await _context.Mercadoria
                .FirstOrDefaultAsync(m => m.MercadoriaID == id);
            if (mercadoria == null)
            {
                return NotFound();
            }

            return View(mercadoria);
        }

        // POST: Remover
        [HttpPost, ActionName("Remover")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoverConfirmed(int id)
        {
            var mercadoria = await _context.Mercadoria.FindAsync(id);
            _context.Mercadoria.Remove(mercadoria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
