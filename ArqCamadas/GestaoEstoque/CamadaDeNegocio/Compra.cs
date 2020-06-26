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

        #region inserir
        /* EM CONSTRUÇÃO
         * public int[] Consumidor(int[] vetor) {
             return vetor;
         }*/
        /*public void COMinserirID() {
            //insere o ID 
        }*/
        public bool COMinserePreco(double preco)
        {
            if (COMvalidaPreco(preco))
            {
                COMpreço = preco;
                return true;
            }
            return false;
        }
        public bool COMinsereDataI(int[] data)
        {
            if (COMvalidaData(data[0], data[1], data[2]))
            {
                COMdataInicial = data;
                return true;
            }
            return false;
        }

        public bool COMinsereDataF(int[] dataI, int[] dataF)
        {
            if (COMvalidaData(dataF[0], dataF[1], dataF[2]) && COMvalidaDatas(dataI, dataF))
            {
                COMdataFinal = dataF;
                return true;
            }
            return false;
        }
        public bool COMinsereStatus()
        {
            return true;
        }
        #endregion

        #region validar
        public bool COMvalidaPreco (double valor)
        {
            return valor < 0 ? false : true;
        }
        public bool COMvalidaData (int dia, int mes, int ano)
        {
            if (!COMvalidaDia(dia)) return false;
            if (!COMvalidaMes(mes)) return false;
            if (!COMvalidaAno(ano)) return false;
            return true;
        }
        public bool COMvalidaDia(int dia)
        {
            return dia > 31 ? false : true; 
        }
        public bool COMvalidaMes (int mes)
        {
            return mes > 12 ? false : true;
        }
        public bool COMvalidaAno (int ano)
        {
            return ano < 2000 ? false : true;
        }
        public bool COMvalidaDatas (int[] data1, int[] data2)
        {
            if (data1[2] > data2[2]) return false; //se o ano for maior
            if (data1[2] == data2[2]) //se o ano for igual
            {
                if (data1[1] == data2[1]) //se o mes for igual
                {
                    return data1[0] <= data2[0] ? true : false; //se o dia é menor
                }
                if (data1[1] > data2[1]) return false;
            }
            return true;
        }
        #endregion

        #region INJEÇÃO
        public bool COMinjetar(CamadaDeNegocios.Compra comprar)
        {
            string commando;
            commando = "Insert INTO Compra"+""+"";
            return true;
        }
        #endregion

        #endregion MÉTODOS

    }
}
