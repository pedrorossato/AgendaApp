using AgendaApp.Models.Tarefa;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendaApp.Controllers
{
    public class TarefaController : Controller
    {
        // GET: Tarefa
        public ActionResult Index()
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                var tarefas = session.Query<Tarefa>().ToList();
                return View(tarefas);
            }
        }

        // GET: Tarefa/Details/5
        public ActionResult Details(int id)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                var tarefas = session.Get<Tarefa>(id);
                return View(tarefas);
            }
        }

        // GET: Tarefa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tarefa/Create
        [HttpPost]
        public ActionResult Create(Tarefa tarefa)
        {
            try
            {
                using (ISession session = SessionFactory.AbrirSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(tarefa);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tarefa/Edit/5
        public ActionResult Edit(int id)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                var aluno = session.Get<Tarefa>(id);
                return View(aluno);
            }
        }

        // POST: Tarefa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Tarefa tarefa)
        {
            try
            {
                using (ISession session = SessionFactory.AbrirSession())
                {
                    var tarefalterada = session.Get<Tarefa>(id);
                    tarefalterada.titulo = tarefa.titulo;
                    tarefalterada.descricao = tarefa.descricao;
                    tarefalterada.dataentrega = tarefa.dataentrega;
                    tarefalterada.concluida = tarefa.concluida;
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(tarefalterada);
                        transaction.Commit();
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tarefa/Delete/5
        public ActionResult Delete(int id)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                var tarefa = session.Get<Tarefa>(id);
                return View(tarefa);
            }
        }

        // POST: Tarefa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Tarefa tarefa)
        {
            try
            {
                using (ISession session = SessionFactory.AbrirSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(tarefa);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
