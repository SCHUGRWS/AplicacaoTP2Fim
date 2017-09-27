//Richard Wilhian Schug
//richard.schug@catolicasc.org.br

using AplicacaoTP2Fim.Models;
using AvaliacaoTP2.Models;
using AvaliacaoTP2.ViewModels;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace AvaliacaoTP2.Controllers
{
    public class AssociationTypeController : Controller
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }

        // GET: AssociationType
        public ActionResult Index()
        {
            var assocList = new AssociationTypeIndexView()
            {
                TiposAssociacoes = _dbContext.AssociantionType.ToList()
            };


            return View(assocList);
        }

        public ActionResult DetalharTipoAssociacao(int id)
        {
            if (id > _dbContext.AssociantionType.Count()) return HttpNotFound();

            AssociationType associacao = _dbContext.AssociantionType.Where(x => x.Id == id).FirstOrDefault();
            
            return View(associacao);
        }
    }
}