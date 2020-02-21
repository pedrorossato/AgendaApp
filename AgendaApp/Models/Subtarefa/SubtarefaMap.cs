using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaApp.Models
{
    public class SubtarefaMap : ClassMap<Subtarefa>
    {
        public SubtarefaMap()
        {
            Id(x => x.id);
            Map(x => x.titulo);
            Map(x => x.concluida);
            References(x => x.tarefa).Column("tarefaid").Cascade.All();
            Table("subtarefas");
        }
    }
}