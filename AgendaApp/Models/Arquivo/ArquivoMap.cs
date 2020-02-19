using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaApp.Models.Arquivo
{
    public class ArquivoMap : ClassMap<Arquivo>
    {
        public ArquivoMap()
        {
            Id(x => x.id);
            Map(x => x.path);
            References(x => x.TarefaID);
        }
    }
}