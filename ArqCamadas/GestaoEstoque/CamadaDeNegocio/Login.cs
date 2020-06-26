using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDeDados;

namespace CamadaDeNegocios
{
    /// <summary>
    /// Classe de controle de Login
    /// </summary>

    #region Classe Login
    public class Login
    {
        #region ATRIBUTOS
        public string user { get; set; }
        public string senha { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string nivel { get; set; }

        #endregion

        #region CONSTRUTOR
        public Login(string nome, string senha)
        {
            this.user = nome;
            this.senha = senha;
        }
        public Login()
        {
            this.user = "admin";
            this.senha = "senha";
        }
        #endregion

        #region MÉTODOS
        public bool UserValido(string user)
        {
            if (user.Length < 3)
                return false;
            return true;
        }
        public bool ValidarSenha()
        {
            return true;
        }
        /*
        public bool LOGvalidaLetraNome(char e) //verifica letra por letra do nome
        {
            if ((!Char.IsLetter(e) && e != (Char)8) && e != (Char)32)
            {
                return false;
            }
            else
                return true;
        }

        public bool LOGvalidaNome(string nome) //verifica o nome inteiro a fim de evitar nomes em branco ou menores de 3 caracteres
        {
            string tempNome = nome.Trim();
            if (tempNome.Length < 3)
                return false;
            return true;
        }

        public bool LOGvalidaUser(string user)
        {
            if (user.Length < 3)
                return false;
            return true;
        }

        public bool LOGvalidaLetraUser(char e)
        {
            if (!Char.IsLetter(e) || Char.IsPunctuation(e))
                return false;
            return true;
        }*/
        #endregion

        private DataSet obtemUsuario(string usuario, string senha)
        {

            Conexao acessoDados = new Conexao();
            return acessoDados.RetornaDataSet("SELECT * FROM Login WHERE Login_username = '" + usuario + "' and Login_senha = '" + senha + "'");

        }

        private DataSet verificaUsuario(string usuario)
        {

            Conexao acessoDados = new Conexao();
            return acessoDados.RetornaDataSet("SELECT Login_username FROM Login WHERE Login_username = '" + usuario + "'");

        }

        public bool cadastraUsuario(string name, string CPF, string usuario, string senha, string nivel)
        {
            DataSet aux = new DataSet();
            aux = this.verificaUsuario(usuario);
            if (aux.Tables[0].Rows.Count == 0)
            {
                Conexao acessoDados2 = new Conexao();
                acessoDados2.ExecutaNQ("insert into Login(Login_username,Login_senha,Login_nome,Login_cpf,Login_nivel) values('" + usuario + "','" + senha + "','" + name + "','" + CPF + "','" + nivel + "')");
                return true;
            }
            return false;

        }

        public bool Cadastrar(string name, string CPF, string usuario, string senha, string nivel)
        {
            cadastraUsuario(name, CPF, usuario, senha, nivel);
            return true;
        }

        public Login Autentica(string usuario, string senha)
        {
            DataSet aux = new DataSet();
            aux = this.obtemUsuario(usuario, senha);
            DataTable oDa = new DataTable();
            oDa = aux.Tables[0];
            Login user = new Login();


            if (aux.Tables[0].Rows.Count > 0)
            {
                string usuariobanco = oDa.Rows[0]["Login_username"].ToString();
                string senhabanco = oDa.Rows[0]["Login_senha"].ToString();
                if (oDa.Rows[0]["Login_username"].ToString() == usuario && oDa.Rows[0]["Login_senha"].ToString() == senha)
                {
                    user.user = oDa.Rows[0]["Login_username"].ToString();
                    user.nivel = oDa.Rows[0]["Login_nivel"].ToString();
                    user.nome = oDa.Rows[0]["Login_nome"].ToString();
                    return user;
                }
                else
                {
                    return null;
                }
            }
            return null;

        }
    }
    #endregion
}
