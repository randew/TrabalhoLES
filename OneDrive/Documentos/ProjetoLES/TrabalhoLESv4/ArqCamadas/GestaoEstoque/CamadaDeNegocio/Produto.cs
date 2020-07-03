using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDeDados;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace CamadaDeNegocios
{
    public class Produto
    {
        public Produto()
        {
            this.PROid = 0L;
            this.PROnome = "";
            this.PROvalor = 0.0;
            this.PROlote = 1L;
        }

        public Produto(string nome, double valor, long id, long lote)
        {
            this.PROid = id;
            this.PROnome = nome;
            this.PROvalor = valor;
            this.PROlote = lote;
        }

        public DataTable ConsultaProduta(string inv)
        {
            DataTable tb = new DataTable();
            try
            {
                Conexao conexao = new Conexao();
                return ((inv == "0") ? conexao.retornaAdapterTB("SELECT * FROM Produto", tb) : conexao.retornaAdapterTB("SELECT * FROM Produto WHERE Prod_Nome LIKE '%" + inv.ToUpper() + "%'", tb));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable FrenteFund(string frente)
        {
            DataTable tb = new DataTable();
            try
            {
                Conexao conexao = new Conexao();
                return ((frente != "0") ? conexao.retornaAdapterTB("SELECT * FROM Produto WHERE Prod_Local ='FUNDO'", tb) : conexao.retornaAdapterTB("SELECT * FROM Produto WHERE Prod_Local ='FRENTE'", tb));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void PesquisaProdutos(string pesquisa)
        {
        }

        public bool PROalterar(long id, string name, double val, long lote, long qtd, string local)
        {
            try
            {
                object[] objArray1 = new object[13];
                objArray1[0] = "UPDATE Produto SET Prod_Nome='";
                objArray1[1] = name;
                objArray1[2] = "', Prod_Valor='";
                objArray1[3] = val;
                objArray1[4] = "', ID_Lote='";
                objArray1[5] = lote;
                objArray1[6] = "', Prod_Qtd='";
                objArray1[7] = qtd;
                objArray1[8] = "', Prod_Local='";
                objArray1[9] = local;
                objArray1[10] = "' WHERE Prod_Nome='";
                objArray1[11] = name;
                objArray1[12] = "'";
                new Conexao().ExecutaNQ(string.Concat(objArray1));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool PROexcluir(long id)
        {
            try
            {
                new Conexao().ExecutaNQ(("DELETE FROM Produto WHERE ID_Prod=" + id) ?? "");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool PROinjetar(long id, string name, double val, long lote, long qtd, string local)
        {
            try
            {
                object[] objArray1 = new object[13];
                objArray1[0] = "insert into Produto(ID_Produto,Prod_Nome,Prod_Valor,ID_Lote,Prod_Qtd,Prod_Local) values('";
                objArray1[1] = id;
                objArray1[2] = "','";
                objArray1[3] = name;
                objArray1[4] = "','";
                objArray1[5] = val;
                objArray1[6] = "','";
                objArray1[7] = lote;
                objArray1[8] = "','";
                objArray1[9] = qtd;
                objArray1[10] = "','";
                objArray1[11] = local;
                objArray1[12] = "')";
                new Conexao().ExecutaNQ(string.Concat(objArray1));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool PROinserirID(string id)
        {
            bool flag2;
            if (!this.PROvalidarID(id))
            {
                flag2 = false;
            }
            else
            {
                this.PROid = int.Parse(id);
                flag2 = true;
            }
            return flag2;
        }

        public bool PROinserirID2(string id)
        {
            this.PROid = int.Parse(id);
            return true;
        }

        public bool PROinserirLocal(string local)
        {
            bool flag2;
            if (!this.PROvalidaLocal(local))
            {
                flag2 = false;
            }
            else
            {
                this.PROlocal = local;
                flag2 = true;
            }
            return flag2;
        }

        public bool PROinserirLote(string lote)
        {
            bool flag2;
            if (!this.PROvalidaLote(lote))
            {
                flag2 = false;
            }
            else
            {
                this.PROlote = int.Parse(lote);
                flag2 = true;
            }
            return flag2;
        }

        public bool PROinserirNome(string nome)
        {
            bool flag2;
            if (!this.PROvalidaNome(nome))
            {
                flag2 = false;
            }
            else
            {
                this.PROnome = nome;
                flag2 = true;
            }
            return flag2;
        }

        public bool PROinserirPreco(string valor)
        {
            bool flag2;
            if (!this.PROvalidaPreco(valor))
            {
                flag2 = false;
            }
            else
            {
                this.PROvalor = double.Parse(valor);
                flag2 = true;
            }
            return flag2;
        }

        public bool PROinserirQtd(string qtd)
        {
            bool flag2;
            if (!this.PROvalidaQtd(qtd))
            {
                flag2 = false;
            }
            else
            {
                this.PROqtd = int.Parse(qtd);
                flag2 = true;
            }
            return flag2;
        }

        public bool PROvalidaLocal(string local) =>
            ((local == "FRENTE") || (local == "FUNDO"));

        public bool PROvalidaLote(string lote)
        {
            long result = 1L;
            return (long.TryParse(lote, out result) && ((result > 0L) && (result <= 20)));
        }

        public bool PROvalidaNome(string nom) =>
            ((nom != null) || (nom.Length <= 100));

        public bool PROvalidaPreco(string val)
        {
            double result = 1.0;
            return (double.TryParse(val, out result) && (double.Parse(val) != 0.0));
        }

        public bool PROvalidaQtd(string qtd)
        {
            long result = 1L;
            return (long.TryParse(qtd, out result) && (result > 0L));
        }

        public bool PROvalidarID(string id)
        {
            bool flag4;
            long result = 1L;
            if (!long.TryParse(id, out result))
            {
                flag4 = false;
            }
            else
            {
                DataSet set = new DataSet();
                flag4 = new Conexao().RetornaDataSet("SELECT ID_Produto FROM Produto WHERE ID_Produto = " + result + ";").Tables[0].Rows.Count == 0;
            }
            return flag4;
        }

        public DataSet selecionaProd() =>
            new Conexao().RetornaDataSet("Select * from Produto");

        public long PROid { get; private set; }

        public string PROnome { get; private set; }

        public double PROvalor { get; private set; }

        public long PROlote { get; private set; }

        public long PROqtd { get; private set; }

        public string PROlocal { get; private set; }
    }
}
