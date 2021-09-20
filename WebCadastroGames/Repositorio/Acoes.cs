﻿using System;
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
            cmd.Parameters.Add("@funcCod", MySqlDbType.VarChar).Value = func.FuncCod;
            cmd.Parameters.Add("@funcNome", MySqlDbType.VarChar).Value = func.FuncNome;
            cmd.Parameters.Add("@funcFuncao", MySqlDbType.VarChar).Value = func.FuncFuncao;
            cmd.Parameters.Add("@funcDtNasc", MySqlDbType.DateTime).Value = data_sistema;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();

            
        }

        public Funcionario ListarCodFuncionario(int cod)
        {
            var comando = String.Format("select * from Funcionario where funcCod = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodFunc = cmd.ExecuteReader();
            return ListarCodFuncionario(DadosCodFunc).FirstOrDefault();
        }

        public List<Funcionario> ListarCodFunc(MySqlDataReader dt)
        {
            var AltAl = new List<Funcionario>();
            while (dt.Read())
            {
                var AlTemp = new Funcionario()
                {
                    FuncCod = ushort.Parse(dt["funcCod"].ToString()),
                    FuncNome = dt["funcNome"].ToString(),
                    FuncCPF = dt["funcCPF"].ToString(),
                    FuncRG = dt["funcRG"].ToString(),
                    FuncDtNasc = DateTime.Parse(dt["funcDtNasc"].ToString()),
                    FuncEnd = dt["funcEnd"].ToString(),
                    FuncTel = dt["funcTel"].ToString(),
                    FuncEmail = dt["funcEmail"].ToString(),
                    FuncCargo = dt["funcCargo"].ToString(),

                };
                AltAl.Add(AlTemp);

            }
            dt.Close();
            return AltAl;
        }

        public List<Funcionario> ListarFuncionario()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from Funcionario", con.ConectarBD());
            var DadosFuncionario = cmd.ExecuteReader();
            return ListarTodosFuncionario(DadosFuncionario);
        }

        public List<Funcionario> ListarTodosFuncionario(MySqlDataReader dt)
        {
            var TodosFuncioanrios = new List<Funcionario>();
            while(dt.Read())
            {
                var FuncionarioTemp = new Funcionario()
                {
                    FuncCod = ushort.Parse(dt["funcCod"].ToString()),
                    FuncNome = dt["funcNome"].ToString(),
                    FuncCPF = dt["funcCPF"].ToString(),
                    FuncRG = dt["funcRG"].ToString(),
                    FuncDtNasc = DateTime.Parse(dt["funcDtNasc"].ToString()),
                    FuncEnd = dt["funcEnd"].ToString(),
                    FuncTel = dt["funcTel"].ToString(),
                    FuncEmail = dt["funcEmail"].ToString(),
                    FuncCargo = dt["funcCargo"].ToString(),

                };
                TodosFuncioanrios.Add(FuncionarioTemp);
            }
            dt.Close();
            return TodosFuncioanrios;
        }
        
    }
}