using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using MStartSupply.Data;
using MStartSupply.Models;

namespace MStartSupply.Controllers
{
    public class SaidaController : Controller
    {

        private readonly MStartSupplyContext _context;

        public SaidaController(MStartSupplyContext context)
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

            var saida = await _context.Saida
                .FirstOrDefaultAsync(m => m.SaidaID == id);
            if (saida == null)
            {
                return NotFound();
            }

            return View(saida);
        }

        // =====================================================================
        // GET: Listagem
        public async Task<IActionResult> Index()
        {
            return View(await _context.Saida.ToListAsync());
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
            [Bind("SaidaID,Quantidade,DataSaida,LocalSaida,MercadoriaID")] Saida saida)
        {
            if (ModelState.IsValid)
            {
                _context.Add(saida);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(saida);
        }

        // =====================================================================
        // GET: Edição
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saida = await _context.Saida.FindAsync(id);
            if (saida == null)
            {
                return NotFound();
            }
            return View(saida);
        }

        // POST: Edição
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("SaidaID,Quantidade,DataSaida,LocalSaida,MercadoriaID")] Saida saida)
        {
            if (id != saida.SaidaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saida);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (saida.SaidaID < 1)
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
            return View(saida);
        }

        // =====================================================================
        // GET: Remover
        public async Task<IActionResult> Remover(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saida = await _context.Saida
                .FirstOrDefaultAsync(m => m.SaidaID == id);
            if (saida == null)
            {
                return NotFound();
            }

            return View(saida);
        }

        // POST: Remover
        [HttpPost, ActionName("Remover")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoverConfirmed(int id)
        {
            var saida = await _context.Saida.FindAsync(id);
            _context.Saida.Remove(saida);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }

}