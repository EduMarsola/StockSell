﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace StockSell
{
    public class ControleDoBanco
    {
        private static string stringConnection = "server=localhost; database=StockSellMaster; port=3306; user id=root; password=0";
        public MySqlConnection conn = new MySqlConnection(stringConnection);
        private MySqlCommand command = new MySqlCommand("");

        public void MudarComando(string novoComando)
        {
            command = new MySqlCommand(novoComando, conn);
        }
        public void AbrirConexao() { conn.Open(); }
        public void FecharConexao() { conn.Close(); }
        public void Execultar()
        {
            conn.Open();
            command.ExecuteNonQuery();
            FecharConexao();
        }
        public MySqlDataReader ExecultarReceber(string comando)
        {
            MudarComando(comando);
             return command.ExecuteReader();
        }

    }
}
