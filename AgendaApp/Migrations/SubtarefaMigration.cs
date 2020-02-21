using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaApp.Migrations
{
    public class SubtarefaMigration : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            try
            {
                Create.Table("subtarefas")
                    .WithColumn("id").AsInt32().PrimaryKey().Identity()
                    .WithColumn("titulo").AsString()
                    .WithColumn("tarefaid").AsInt32().ForeignKey("tarefas", "id")
                    .WithColumn("concluida").AsBoolean();
            }
            catch
            {
                throw new NotImplementedException();
            }

        }
    }
}