using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace AgendaApp.Models.Tarefa
{
    public class Tarefa
    {
        public virtual int id { get; set; }
        [Display(Name = "Título")]
        public virtual string titulo { get; set; }
        [Display(Name = "Descrição")]
        public virtual string descricao { get; set; }
        [Display(Name = "Cadastrado em")]
        public virtual DateTime cadastrado_em { get; }
        [Display(Name = "Data de entrega")]
        [DataType(DataType.Date)]
        public virtual DateTime? dataentrega { get; set; }
        [Display(Name = "Concluida")]
        public virtual bool concluida { get; set; }
        public virtual IList<Arquivo> Arquivos { get; set; }
        public Tarefa()
        {
            cadastrado_em = DateTime.Now;
        }
    }
}