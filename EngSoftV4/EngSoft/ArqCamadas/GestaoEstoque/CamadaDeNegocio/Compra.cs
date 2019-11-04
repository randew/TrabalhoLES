using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CamadaDeNegocios
{
    public class Compra
    {
        #region ATRIBUTOS
        public double COMpreço { get; private set; }
        public int[] COMdataInicial { get; private set; }
        public int[] COMdataFinal { get; set; }
        public int[] COMstatus { get; private set; }
        /*Observação sobre atributos:
         * COMdata: Posição[0]= dia, Posição[1]=mês, Posição[2]=ano;
         * COMstatus: Posição[0]= em aberto, Posição[1]=a caminho, Posição[2]=finalizada,
         * Posição[3]=Cancelada.
        */
        #endregion ATRIBUTOS

        #region CONSTRUTORES
        public Compra()
        {
            this.COMpreço = 0.00;
            this.COMdataInicial = new int[3] { 01, 01, 1970 };
            this.COMdataFinal = new int[3] { 02, 01, 1971 };
            this.COMstatus = new int[4] { 0, 1, 2, 3 };
        }
        public Compra(string id, double preco, int[] dataI, int[] dataF, int[] COMstatus)
        {
            this.COMpreço = preco;
            this.COMdataInicial = dataI;
            this.COMdataFinal = dataF;
            this.COMstatus = COMstatus;
        }
        #endregion CONSTRUTORES

        #region MÉTODOS
        /* EM CONSTRUÇÃO
         * public int[] Consumidor(int[] vetor) {
             return vetor;
         }*/
        /*public void COMinserirID() {
            //insere o ID 
        }*/
        public bool CONinserePreco()
        {
            return true;
        }
        public bool CONinsereData()
        {
            return true;
        }
        public bool CONinsereStatus()
        {
            return true;
        }

        #region INJEÇÃO
        public bool COMinjetar(CamadaDeNegocios.Compra comprar)
        {
            return true;
        }
        #endregion

        #endregion MÉTODOS

    }
}
