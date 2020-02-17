using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaApp.Models.Tarefa
{
    public class Tarefa
    {
        public virtual int id { get; set; }
        public virtual string titulo { get; set; }
        public virtual string descricao { get; set; }
        public virtual DateTime cadastrado_em { get; }
        public virtual DateTime dataentrega { get; set; }
        public virtual bool concluida { get; set; }
        public Tarefa()
        {
            cadastrado_em = DateTime.UtcNow;
        }
    }
}