using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendaApp.Models
{
    public class Subtarefa
    {
        public virtual int id { get; set; }
        [Display(Name = "Título")]
        public virtual string titulo { get; set; }
        public virtual bool concluida { get; set; }
        public virtual Tarefa tarefa { get; set; }
    }
}