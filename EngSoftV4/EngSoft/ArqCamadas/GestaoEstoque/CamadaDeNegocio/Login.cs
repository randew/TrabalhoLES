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
        public bool UserValido()
        {
            return true;
        }
        public bool ValidarSenha()
        {
            return true;
        }
        #endregion

        private DataSet obtemUsuario(string usuario, string senha)
        {

            Conexao acessoDados = new Conexao();
            return acessoDados.RetornaDataSet("SELECT * FROM Login WHERE Login_username = '" + usuario + "' and Login_senha = '" + senha + "'");

        }

        private DataSet verificaUsuario(string usuario)
        {

            Conexao acessoDados = new Conexao();
            return acessoDados.RetornaDataSet("SELECT usuario FROM Login WHERE Login_username = '" + usuario + "'");

        }
        
        public bool cadastraUsuario(string name, string RG, string CPF, string telefone, string usuario, string senha)
        {
            DataSet aux = new DataSet();
            aux = this.verificaUsuario(usuario);
            if (aux.Tables[0].Rows.Count == 0)
            {
                Conexao acessoDados2 = new Conexao();
                acessoDados2.ExecutaNQ("insert into Tecnico(nome,RG,CPF,telefone,usuario,senha) values('" + name + "','" + RG + "','" + CPF + "','" + telefone + "','" + usuario + "','" + senha + "')");
                return true;
            }
            else return false;

        }

        public bool Cadastrar(string name, string RG, string CPF, string telefone, string usuario, string senha)
        {
            cadastraUsuario(name, RG, CPF, telefone, usuario, senha);
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



                string usuariobanco = oDa.Rows[0]["usuario"].ToString();
                string senhabanco = oDa.Rows[0]["senha"].ToString();
                if (oDa.Rows[0]["usuario"].ToString() == usuario && oDa.Rows[0]["senha"].ToString() == senha)
                {
                    user.user = oDa.Rows[0]["usuario"].ToString();
                    user.nivel = oDa.Rows[0]["nivel"].ToString();
                    user.nome = oDa.Rows[0]["nome"].ToString();
                    //user.id = oDa.Rows[0]["id_tecnicos"].ToString();
                    return user;
                }
                else
                {
                    return null;
                }
            }
            else return null;

        }

        public string RecuperaNomeTecnico(int idTecnico)
        {
            try
            {
                Conexao camadaDados = new Conexao();
                string sql = "SELECT nome FROM Tecnico WHERE id_Tecnicos = " + idTecnico;
                return camadaDados.RetornaDataSet(sql).Tables[0].Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "Tecnico não encontrado";
                throw;
            }

        }
        //aaaaaaaaaaa
    }
    #endregion
}
