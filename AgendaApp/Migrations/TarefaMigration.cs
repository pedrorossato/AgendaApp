using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaApp.Migrations
{
    [Migration(1)]
    public class TarefaMigration : Migration
    {
        public override void Up()
        {
            try {
                Create.Table("tarefas")
                    .WithColumn("id").AsInt32().PrimaryKey().Identity()
                    .WithColumn("titulo").AsString()
                    .WithColumn("descricao").AsString()
                    .WithColumn("cadastrado_em").AsDateTime().NotNullable()
                    .WithColumn("dataentrega").AsDateTime()
                    .WithColumn("concluida").AsBoolean();

            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public override void Down()
        {
            Delete.Table("Down");
        }
    }
}