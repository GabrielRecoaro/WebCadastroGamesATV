using System;
using WebCadastroGames.Repositorio;
using MySql.Data.MySqlClient;
using WebCadastroGames.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCadastroGames.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarFuncionario(Funcionario func)
        {
            string data_sistema = Convert.ToDateTime(func.FuncDtNasc).ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@funcCod", MySqlDbType.VarChar).Value = FuncCod;
        }
    }
}