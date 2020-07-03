using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDeDados;
using System.Text.RegularExpressions;


namespace CamadaDeNegocios
{
    public class Compra
    {
        public Compra()
        {
            this.COMpreço = 0.0;
            this.COMdataInicial = new int[] { 1, 1, 0x7b2 };
            this.COMdataFinal = new int[] { 2, 1, 0x7b3 };
            this.COMstatus = new int[] { 0, 1, 2, 3 };
        }

        public Compra(string id, double preco, int[] dataI, int[] dataF, int[] COMstatus)
        {
            this.COMpreço = preco;
            this.COMdataInicial = dataI;
            this.COMdataFinal = dataF;
            this.COMstatus = COMstatus;
        }

        /*public bool COMinjetar(Compra comprar) =>
            true;*/

        public bool COMinjetar(string cnpj, int id_prod, string status, DateTime data_inicial, DateTime data_final)
        {
            try
            {
                object[] objArray1 = new object[11];
                objArray1[0] = "insert into Compra(ID_CNPJ,ID_Produto,Comp_Status,Comp_DataInicial,Comp_DataFinal) values('";
                objArray1[1] = cnpj;
                objArray1[2] = "','";
                objArray1[3] = id_prod;
                objArray1[4] = "','";
                objArray1[5] = status;
                objArray1[6] = "','";
                objArray1[7] = data_inicial;
                objArray1[8] = "','";
                objArray1[9] = data_final;
                objArray1[10] = "')";
                new Conexao().ExecutaNQ(string.Concat(objArray1));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool COMinsereDataF(int[] dataI, int[] dataF)
        {
            bool flag2;
            if (!(this.COMvalidaData(dataF[0], dataF[1], dataF[2]) && this.COMvalidaDatas(dataI, dataF)))
            {
                flag2 = false;
            }
            else
            {
                this.COMdataFinal = dataF;
                flag2 = true;
            }
            return flag2;
        }

        public bool COMinsereDataI(int[] data)
        {
            bool flag2;
            if (!this.COMvalidaData(data[0], data[1], data[2]))
            {
                flag2 = false;
            }
            else
            {
                this.COMdataInicial = data;
                flag2 = true;
            }
            return flag2;
        }

        public bool COMinserePreco(double preco)
        {
            bool flag2;
            if (!this.COMvalidaPreco(preco))
            {
                flag2 = false;
            }
            else
            {
                this.COMpreço = preco;
                flag2 = true;
            }
            return flag2;
        }

        public bool COMinsereStatus() =>
            true;

        public bool COMvalidaAno(int ano) =>
            (ano >= 0x7d0);

        public bool COMvalidaData(int dia, int mes, int ano) =>
            (this.COMvalidaDia(dia) ? (this.COMvalidaMes(mes) ? this.COMvalidaAno(ano) : false) : false);

        public bool COMvalidaDatas(int[] data1, int[] data2)
        {
            bool flag2;
            if (data1[2] <= data2[2])
            {
                if (data1[2] == data2[2])
                {
                    if (data1[1] != data2[1])
                    {
                        if (data1[1] > data2[1])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return (data1[0] <= data2[0]);
                    }
                }
                flag2 = true;
            }
            else
            {
                flag2 = false;
            }
            return flag2;
        }

        public bool COMvalidaDia(int dia) =>
            (dia <= 0x1f);

        public bool COMvalidaMes(int mes) =>
            (mes <= 12);

        public bool COMvalidaPreco(double valor) =>
            (valor >= 0.0);

        public double COMpreço { get; private set; }

        public int[] COMdataInicial { get; private set; }

        public int[] COMdataFinal { get; set; }

        public int[] COMstatus { get; private set; }
    }
}
