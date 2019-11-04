using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace wfaGestaoEstoque.Controller
{
    class Compra
    {
        #region ATRIBUTOS
        public string COMid { get; private set; }
        public double COMpreço { get; private set; }
        public DateTime COMdata { get; private set; }
        public int[] COMstatus { get; private set; }
        //possivel troca por enums
        #endregion ATRIBUTOS

        #region CONSTRUTORES
        public Compra() {
            //  this.COMdata = ;
            this.COMid = "";
            this.COMpreço = 0.00;
         //   this.COMstatus[3] = (0, 1, 2, 3);
        }
        public Compra(string id,double preco, DateTime data, int[] COMstatus)
        {
            this.COMid = id;
            this.COMpreço = preco;
            this.COMdata = data;
            this.COMstatus = COMstatus;
        }
        #endregion CONSTRUTORES

        #region MÉTODOS
        /* EM CONSTRUÇÃO
         * public int[] Consumidor(int[] vetor) {
             return vetor;
         }*/
        #endregion MÉTODOS

    }
}
