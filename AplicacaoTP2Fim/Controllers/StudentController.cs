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
using System.Data.Entity;

namespace AvaliacaoTP2.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }

        // GET: Student
        public ActionResult Index()
        {
            var studentList = new StudentIndexView()
            {
                Alunos = _dbContext.Student.ToList()
            };

            return View(studentList);
        }

        public ActionResult DetalharAluno(int id)
        {
            if (id > _dbContext.Student.Count()) return HttpNotFound();

            Student aluno = _dbContext.Student.Include(p => p.Faixa).Include(p => p.TipoAssociacao).Where(x => x.Id == id).FirstOrDefault();


            return View(aluno);
        }
    }
}