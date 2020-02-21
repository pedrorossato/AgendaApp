using AgendaApp.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendaApp.Controllers
{
    public class SubtarefaController : Controller
    {
        // GET: Subtarefa
        public ActionResult Index()
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                var subtarefas = session.Query<Subtarefa>().ToList();
                return View(subtarefas);
            }
        }

        // GET: Subtarefa/Details/5
        public ActionResult Details(int id)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                var subtarefas = session.Get<Subtarefa>(id);
                return View(subtarefas);
            }
        }

        // GET: Subtarefa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subtarefa/Create
        [HttpPost]
        public ActionResult Create(Subtarefa subtarefa)
        {
            try
            {
                using (ISession session = SessionFactory.AbrirSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(subtarefa);
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

        // GET: Subtarefa/Edit/5
        public ActionResult Edit(int id)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                var subtarefa = session.Get<Tarefa>(id);
                return View(subtarefa);
            }
        }

        // POST: Subtarefa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Subtarefa subtarefa)
        {
            try
            {
                using (ISession session = SessionFactory.AbrirSession())
                {
                    var subtarefalterada = session.Get<Subtarefa>(id);
                    subtarefalterada.titulo = subtarefa.titulo;
                    subtarefalterada.concluida = subtarefa.concluida;
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(subtarefalterada);
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

        // GET: Subtarefa/Delete/5
        public ActionResult Delete(int id)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                var subtarefa = session.Get<Tarefa>(id);
                return View(subtarefa);
            }
        }

        // POST: Subtarefa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Subtarefa subtarefa)
        {
            try
            {
                using (ISession session = SessionFactory.AbrirSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(subtarefa);
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
