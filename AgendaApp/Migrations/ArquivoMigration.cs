using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaApp.Migrations
{
    public class ArquivoMigration : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            try {
                Create.Table("arquivos")
                    .WithColumn("id").AsInt32().PrimaryKey().Identity()
                    .WithColumn("path").AsString()
                    .WithColumn("tarefaid").AsInt32().ForeignKey("tarefas","id");
            }
            catch {
                throw new NotImplementedException();
            }
            
        }
    }
}