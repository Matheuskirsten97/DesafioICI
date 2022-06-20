﻿namespace ProvaCandidato.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AJUSTES_Validacoes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "data_nascimento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "data_nascimento", c => c.DateTime());
        }
    }
}
