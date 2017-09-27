//Richard Wilhian Schug
//richard.schug@catolicasc.org.br

using AplicacaoTP2Fim.Models;
using AvaliacaoTP2.Models;
using AvaliacaoTP2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvaliacaoTP2.Controllers
{
    public class BandController : Controller
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }

        // GET: Band
        public ActionResult Index()
        {
            var bandList = new BandIndexView()
            {
                Faixas = _dbContext.Band.ToList()
            };
            
            return View(bandList);
        }

        public ActionResult DetalharFaixa(int id)
        {
            if (id > _dbContext.Band.Count()) return HttpNotFound();

            Band faixa = _dbContext.Band.Where(x => x.Id == id).FirstOrDefault();

            return View(faixa);
        }
    }
}