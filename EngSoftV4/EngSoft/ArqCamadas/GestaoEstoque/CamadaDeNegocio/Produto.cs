using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDeNegocios
{
    public class Produto
    {
        #region ATRIBUTOS
        public int PROid { get; private set; }
        public string PROnome { get; private set; }
        public double PROvalor { get; private set; }
        public string PROfornecedor { get; private set; }
        public string PROlote { get; private set; }
        #endregion

        #region CONSTRUTORES
        public Produto()
        {
            this.PROid = 0;
            this.PROnome = "";
            this.PROvalor = 0.00;
            this.PROfornecedor = "";
            this.PROlote = "";
        }
        public Produto(string nome, double valor, int id, string forn, string lote)
        {
            this.PROid = id;
            this.PROnome = nome;
            this.PROvalor = valor;
            this.PROfornecedor = forn;
            this.PROlote = lote;

        }
        #endregion

        #region MÉTODOS

        #region inserir 
        #endregion

        #region validar 
        #endregion

        #region INJEÇÃO
        public bool PROinjetar(CamadaDeNegocios.Produto prod)
        {
            return true;
        }
        #endregion

        #endregion

    }
}
