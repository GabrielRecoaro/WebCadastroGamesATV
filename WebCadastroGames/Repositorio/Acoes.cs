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
            MySqlCommand cmd = new MySqlCommand("insert into tbFuncionario values(@funcCod, @funcNome, @funcCPF, @funcRG, @funcDtNasc, @funcEnd, @funcTel, @funcEmail, @funcCargo)", con.ConectarBD());
            cmd.Parameters.Add("@funcCod", MySqlDbType.VarChar).Value = func.FuncCod;
            cmd.Parameters.Add("@funcNome", MySqlDbType.VarChar).Value = func.FuncNome;
            cmd.Parameters.Add("@funcCPF", MySqlDbType.VarChar).Value = func.FuncCPF;
            cmd.Parameters.Add("@funcRG", MySqlDbType.VarChar).Value = func.FuncRG;
            cmd.Parameters.Add("@funcDtNasc", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@funcEnd", MySqlDbType.VarChar).Value = func.FuncEnd;
            cmd.Parameters.Add("@funcTel", MySqlDbType.VarChar).Value = func.FuncTel;
            cmd.Parameters.Add("@funcEmail", MySqlDbType.VarChar).Value = func.FuncEmail;
            cmd.Parameters.Add("@funcCargo", MySqlDbType.VarChar).Value = func.FuncCargo;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();

            
        }

        public void CadastrarJogo(Jogo jogo)
        {
            string data_sistema = Convert.ToDateTime(jogo.JogoDtLanc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbJogo values(@JogoCod, @JogoNome, @JogoVers, @JogoDes, @JogoGender, @JogoFaixa, @JogoPlat, @JogoDtLanc, @JogoSinopse)", con.ConectarBD());
            cmd.Parameters.Add("@JogoCod", MySqlDbType.Int16).Value = jogo.JogoCod;
            cmd.Parameters.Add("@JogoNome", MySqlDbType.VarChar).Value = jogo.JogoNome;
            cmd.Parameters.Add("@JogoVers", MySqlDbType.VarChar).Value = jogo.JogoVers;
            cmd.Parameters.Add("@JogoDes", MySqlDbType.VarChar).Value = jogo.JogoDes;
            cmd.Parameters.Add("@JogoGender", MySqlDbType.VarChar).Value = jogo.JogoDes;
            cmd.Parameters.Add("@JogoFaixa", MySqlDbType.VarChar).Value = jogo.JogoFaixa;
            cmd.Parameters.Add("@JogoPlat", MySqlDbType.VarChar).Value = jogo.JogoPlat;
            cmd.Parameters.Add("@JogoDtLanc", MySqlDbType.VarChar).Value = data_sistema;
            cmd.Parameters.Add("@JogoSinopse", MySqlDbType.VarChar).Value = jogo.JogoSinopse;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();


        }

        public void CadastrarCliente(Cliente cliente)
        {
            string data_sistema = Convert.ToDateTime(cliente.CliDtNasc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbCliente values(@CliNome, @CliCPF, @CliDtNasc, @CliEmail, @CliTel, @CliEnd)", con.ConectarBD());
            cmd.Parameters.Add("@CliNome", MySqlDbType.VarChar).Value = cliente.CliNome;
            cmd.Parameters.Add("@CliCPF", MySqlDbType.VarChar).Value = cliente.CliCPF;
            cmd.Parameters.Add("@CliDtNasc", MySqlDbType.VarChar).Value = data_sistema;
            cmd.Parameters.Add("@CliEmail", MySqlDbType.VarChar).Value = cliente.CliEmail;
            cmd.Parameters.Add("@CliTel", MySqlDbType.DateTime).Value = cliente.CliTel;
            cmd.Parameters.Add("@CliEnd", MySqlDbType.VarChar).Value = cliente.CliEnd;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();


        }
        /******** código comentado ******
        public Funcionario ListarCodFuncionario(int cod)
        {
            var comando = String.Format("select * from tbFuncionario where funcCod = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodFunc = cmd.ExecuteReader();
            return ListarCodFunc(DadosCodFunc).FirstOrDefault();
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
            MySqlCommand cmd = new MySqlCommand("Select * from tbFuncionario", con.ConectarBD());
            var DadosFuncionario = cmd.ExecuteReader();
            return ListarTodosFuncionario(DadosFuncionario);
        }

        public List<Funcionario> ListarTodosFuncionario(MySqlDataReader dt)
        {
            var TodosFuncionarios = new List<Funcionario>();
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
                TodosFuncionarios.Add(FuncionarioTemp);
            }
            dt.Close();
            return TodosFuncionarios;

        }********* código comentado ******/

    }
}