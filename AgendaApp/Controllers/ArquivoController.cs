﻿using AgendaApp.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendaApp.Controllers
{
    public class ArquivoController : Controller
    {
        // GET: Arquivo
        public ActionResult Index()
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                var arquivos = session.Query<Arquivo>().ToList();
                return View(arquivos);
            }
        }

        // GET: Arquivo/Details/5
        public ActionResult Details(int id)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                var arquivos = session.Get<Arquivo>(id);
                return View(arquivos);
            }
        }

        // GET: Arquivo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Arquivo/Create
        [HttpPost]
        public ActionResult Create(Arquivo arquivo)
        {
            try
            {
                using (ISession session = SessionFactory.AbrirSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(arquivo);
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

        // GET: Arquivo/Edit/5
        public ActionResult Edit(int id)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                var arquivo = session.Get<Arquivo>(id);
                return View(arquivo);
            }
        }

        // POST: Arquivo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Arquivo arquivo)
        {
            try
            {
                using (ISession session = SessionFactory.AbrirSession())
                {
                    var arquivoeditado = session.Get<Arquivo>(id);
                    arquivoeditado.path = arquivo.path;
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(arquivoeditado);
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

        // GET: Arquivo/Delete/5
        public ActionResult Delete(int id)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                var arquivo = session.Get<Arquivo>(id);
                return View(arquivo);
            }
        }

        // POST: Arquivo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Arquivo arquivo)
        {
            try
            {
                using (ISession session = SessionFactory.AbrirSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(arquivo);
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
