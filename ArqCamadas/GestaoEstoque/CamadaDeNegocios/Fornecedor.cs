using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEstoque
{
    class Fornecedor
    {
        #region ATRIBUTOS
        public string FORnome { get; private set; }
        public string FORcnpj { get; private set; }
        public string FORnacl { get; private set; }
        public string FORcep { get; private set; }
        public string FORrua { get; private set; }
        #endregion

        #region CONSTRUTORES
        public Fornecedor()
        {
            FORnome = "";
        }
        public Fornecedor(string nome)
        {
            FORnome = nome;
        }
        #endregion

        #region MÉTODOS
        public bool FORinsereNome(string original)
        {
            if (FORvalidaNome(original))
            {
                FORnome = original;
                return true;
            }
            return false;
        }
        public bool FORvalidaNome(string nome)
        {
            return true;
        }
        #endregion
    }
}
