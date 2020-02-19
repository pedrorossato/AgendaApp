using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaApp.Models.Arquivo
{
    public class Arquivo
    {
        public virtual int id { get; set; }
        public virtual string path { get; set; }
        public virtual Tarefa TarefaID { get; set; }
    }
}