using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace AgendaApp.Models.Tarefa
{
    public class TarefaMap : ClassMap<Tarefa>
    {
        public TarefaMap()
        {
            Id(x => x.id);
            Map(x =>x.titulo);
            Map(x =>x.descricao);
            Map(x =>x.cadastrado_em);
            Map(x =>x.dataentrega);
            Map(x =>x.concluida);
            HasMany(x => x.Arquivos);
            Table("tarefas");
        }
    }
}