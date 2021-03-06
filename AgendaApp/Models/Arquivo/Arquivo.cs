﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendaApp.Models
{
    public class Arquivo
    {
        public virtual int id { get; set; }
        [Display(Name = "Caminho")]
        public virtual string path { get; set; }
        public virtual Tarefa tarefaid { get; set; }
    }
}