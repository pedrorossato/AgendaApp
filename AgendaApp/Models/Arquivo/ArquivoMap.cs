using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaApp.Models
{
    public class ArquivoMap : ClassMap<Arquivo>
    {
        public ArquivoMap()
        {
            Id(x => x.id);
            Map(x => x.path);
            References(x => x.tarefaid).Column("tarefaid").Cascade.All() ; //um arquivo pertence à uma tarefa
            Table("arquivos");
        }
    }
}