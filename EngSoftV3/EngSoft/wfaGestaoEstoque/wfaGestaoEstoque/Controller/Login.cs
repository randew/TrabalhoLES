using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaGestaoEstoque.Controller
{
    /// <summary>
    /// Classe de controle de Login
    /// </summary>

    #region Classe Login
    class Login
    {
        #region ATRIBUTOS
        public string User { get; private set; }
        public string senha { get; private set; }
        #endregion

        #region CONSTRUTOR
        public Login(string nome, string senha){
            this.User=nome;
            this.senha=senha;
        }
        public Login()
        {
            this.User = "admin";
            this.senha = "senha";
        }
        #endregion

        public bool UserValido() {
            return true;
        }
        public bool ValidarSenha()
        {
            return true;
        }
    }
    #endregion
}
