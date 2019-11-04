using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEstoque
{ 
    class Venda
    {
        #region ATRIBUTOS
        public string VENid { get; private set; }
        public double VENvalor { get; private set; }
        #endregion ATRIBUTOS

        #region CONSTRUTORES
        public Venda()
        {
            this.VENid = "";
        }
        public Venda(string id)
        {
            VENid = id;
        }
        #endregion CONSTRUTORES

        #region MÉTODOS
        public int VENokok(int hue)
        {
            return hue;
        }
        #endregion MÉTODOS
    }
}
