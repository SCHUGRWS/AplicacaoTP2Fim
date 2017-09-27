namespace AplicacaoTP2Fim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InserirStudent : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO STUDENTS (Nome,Cpf,Faixa_Id,TipoAssociacao_Id) VALUES ('Martim Castro Ribeiro','158.778.735-0',1,1)");

            Sql("INSERT INTO STUDENTS (Nome,Cpf,Faixa_Id,TipoAssociacao_Id) VALUES ('Lucas Alves Melo','916.749.332-74',4,3)");

            Sql("INSERT INTO STUDENTS (Nome,Cpf,Faixa_Id,TipoAssociacao_Id) VALUES ('Breno Castro Carvalho','454.019.800-94',2,2)");

            Sql("INSERT INTO STUDENTS (Nome,Cpf,Faixa_Id,TipoAssociacao_Id) VALUES ('Laura Cardoso Rocha','361.089.665-56',6,4)");
        }
        
        public override void Down()
        {
        }
    }
}
