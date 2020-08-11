using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data.Infrastructure.Context;
using Domain.Model.Models;
using Domain.Model.Interfaces.Services;

namespace Mvc_.NET.Controllers
{
    public class MoleculaController : Controller
    {
        private readonly IAutorService _autorService;
        private readonly IMoleculaService _moleculaService;

        public MoleculaController(
            IAutorService autorService,
            IMoleculaService moleculaService)
        {
            _autorService = autorService;
            _moleculaService = moleculaService;
        }

        // GET: Molecula
        public IActionResult Index()
        {
            var bibliotecaContext = _moleculaService.GetAll();
            return View(bibliotecaContext.ToList());
        }

        // GET: Molecula/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moleculaModel = _moleculaService.GetById(id.Value);
            if (moleculaModel == null)
            {
                return NotFound();
            }

            return View(moleculaModel);
        }

        // GET: Molecula/Create
        public IActionResult Create()
        {
            var autores = _autorService.GetAll();
            ViewData["AutorId"] = new SelectList(autores, "Id", "Id");
            return View();
        }

        // POST: Molecula/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Rendimento,FormulaMolecular,TipoReacao,Lancamento,AutorId")] MoleculaModel moleculaModel)
        {
            if (ModelState.IsValid)
            {
                _moleculaService.Create(moleculaModel);
                return RedirectToAction(nameof(Index));
            }
            var autores = _autorService.GetAll();
            ViewData["AutorId"] = new SelectList(autores, "Id", "Id", moleculaModel.AutorId);
            return View(moleculaModel);
        }

        // GET: Molecula/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moleculaModel = _moleculaService.GetById(id.Value);
            if (moleculaModel == null)
            {
                return NotFound();
            }
            var autores = _autorService.GetAll();
            ViewData["AutorId"] = new SelectList(autores, "Id", "Id", moleculaModel.AutorId);
            return View(moleculaModel);
        }

        // POST: Molecula/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Rendimento,FormulaMolecular,TipoReacao,Lancamento,AutorId")] MoleculaModel moleculaModel)
        {
            if (id != moleculaModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _moleculaService.Update(moleculaModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoleculaModelExists(moleculaModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            var autores = _autorService.GetAll();
            ViewData["AutorId"] = new SelectList(autores, "Id", "Id", moleculaModel.AutorId);
            return View(moleculaModel);
        }

        // GET: Molecula/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moleculaModel = _moleculaService.GetById(id.Value);
            if (moleculaModel == null)
            {
                return NotFound();
            }

            return View(moleculaModel);
        }

        // POST: Molecula/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _moleculaService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool MoleculaModelExists(int id)
        {
            return _moleculaService.GetById(id) != null;
        }
    }
}
