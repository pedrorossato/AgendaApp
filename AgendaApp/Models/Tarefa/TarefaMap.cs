using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace AgendaApp.Models
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
            //Defini-se que uma tarefa tem vários arquivos e subtarefas porém o outro lado das relações são responsáveis por salvar
            HasMany(x => x.Arquivos).Inverse().Cascade.All();
            HasMany(x => x.Subtarefas).Inverse().Cascade.All();
            Table("tarefas");
        }
    }
}