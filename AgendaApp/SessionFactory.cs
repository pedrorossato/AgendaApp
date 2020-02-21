using AgendaApp.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaApp
{
    public class SessionFactory
    {
        private static string ConnectionString = "Server=localhost; Port=5432; User Id=postgres; Password=postgres; Database=postgres";
        private static ISessionFactory session;

        public static ISessionFactory CriarSession()
        {
            if (session != null)
                return session;

            IPersistenceConfigurer configDB = PostgreSQLConfiguration.PostgreSQL82.ConnectionString(ConnectionString);

            var configMap = Fluently.Configure().Database(configDB).Mappings(c => c.FluentMappings.AddFromAssemblyOf<TarefaMap>());

            session = configMap.BuildSessionFactory();

            return session;
        }

        public static ISession AbrirSession()
        {
            return CriarSession().OpenSession();
        }
    }
}