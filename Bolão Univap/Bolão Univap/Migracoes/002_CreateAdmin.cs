using Bolão_Univap.Database;
using System.Data;

namespace Bolão_Univap
{
    internal class _002_CreateAdmin : IMigration
    {
        public string Name => "002_CreateAdmin";

        public void Up()
        {

            DataTable dt = DataBase.Consultas(
                "SELECT * FROM administradores"
            );

            if (dt.Rows.Count == 0)
            {
                DataBase.Add_deletar_alterar(
                    @"INSERT INTO administradores (email, senha)
                    VALUES ('testes@gmail.com','72625348')"
                );
            }

        }
    }
}