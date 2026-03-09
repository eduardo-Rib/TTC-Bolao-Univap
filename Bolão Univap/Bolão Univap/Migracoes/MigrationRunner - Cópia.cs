using Bolão_Univap.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Bolão_Univap
{
    internal class MigrationRunner
    {

        public static bool RunMigrations(Action<int> progress)
        {
            try
            {
                // cria o banco de dados se não existir
                DataBase.ConectarServidor();
                DataBase.ExecuteSemConectar(
                    "CREATE DATABASE IF NOT EXISTS BolaoUnivap"
                );

                DataBase.Desconectar();
                progress(10);


                DataBase.Conectar();

                // cria tabela de controle
                string migrationTable = @"CREATE TABLE IF NOT EXISTS migrations (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        migration VARCHAR(100),
                        executed_at DATETIME
                    );";

                DataBase.Add_deletar_alterar(migrationTable);

                List<IMigration> migrations = new List<IMigration>()
                {
                    new _001_CreateTables(),
                    new _002_CreateAdmin()
                };

                int step = 100 / migrations.Count;
                int progressValue = 0;

                foreach (var migration in migrations)
                {
                    if (!MigrationExecuted(migration.Name))
                    {
                        migration.Up();
                        RegisterMigration(migration.Name);
                    }

                    progressValue += step;
                    progress(progressValue);
                }

                DataBase.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        static bool MigrationExecuted(string name)
        {
            var dt = DataBase.Consultas($"SELECT * FROM migrations WHERE migration = '{name}'");

            return dt.Rows.Count > 0;
        }

        static void RegisterMigration(string name)
        {
            DataBase.Add_deletar_alterar(
                $"INSERT INTO migrations (migration, executed_at) VALUES ('{name}', NOW())"
            );
        }

    }
}