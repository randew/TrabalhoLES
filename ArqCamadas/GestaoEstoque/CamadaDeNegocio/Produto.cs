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
        #region ATRIBUTOS
        public long PROid { get; private set; }
        public string PROnome { get; private set; }
        public double PROvalor { get; private set; }
        public long PROlote { get; private set; }
        public long PROqtd { get; private set; }
        public string PROlocal { get; private set; }
        #endregion

        #region CONSTRUTORES
        public Produto()
        {
            this.PROid = 0;
            this.PROnome = "";
            this.PROvalor = 0.00;

            this.PROlote = 1;
        }
        public Produto(string nome, double valor, long id, long lote)
        {
            this.PROid = id;
            this.PROnome = nome;
            this.PROvalor = valor;

            this.PROlote = lote;

        }
        #endregion

        #region MÉTODOS

        #region inserir 
        public bool PROinserirID(string id)
        {
            if (PROvalidarID(id))
            {
                PROid = int.Parse(id);
                return true;
            }
            return false;
        }

        public bool PROinserirID2(string id)
        {
            PROid = int.Parse(id);
            return true;

        }

        public bool PROinserirNome(string nome)
        {
            if (PROvalidaNome(nome))
            {
                PROnome = nome;
                return true;
            }
            return false;
        }
        public bool PROinserirPreco(string valor)
        {
            if (PROvalidaPreco(valor))
            {
                PROvalor = double.Parse(valor);
                return true;
            }
            return false;
        }
        public bool PROinserirLote(string lote)
        {
            if (PROvalidaLote(lote))
            {
                PROlote = int.Parse(lote);
                return true;
            }
            return false;
        }
        public bool PROinserirQtd(string qtd)
        {
            if (PROvalidaQtd(qtd))
            {
                PROqtd = int.Parse(qtd);
                return true;
            }
            return false;
        }
        public bool PROinserirLocal(string local)
        {
            if (PROvalidaLocal(local))
            {
                PROlocal = local;
                return true;
            }
            return false;
        }
        #endregion

        #region validar 
        public bool PROvalidarID(string id)
        {
            long x = 1;
            bool foi = long.TryParse(id, out x);
            //x = long.Parse(id);
            if (foi)
            {
                Conexao AcessoDados = new Conexao();

                DataSet aux = new DataSet();
                aux = AcessoDados.RetornaDataSet("SELECT ID_Produto FROM Produto WHERE ID_Produto = " + x + ";");
                if (aux.Tables[0].Rows.Count == 0)
                    return true;
                return false;
            }
            return false;
        }
        public bool PROvalidaNome(string nom)
        {
            if (nom != null || nom.Length <= 100)
                return true;
            return false;
        }
        public bool PROvalidaPreco(string val)
        {
            double x = 1;
            bool foi = double.TryParse(val, out x);
            if (foi)
            {
                if (double.Parse(val) <= 0)
                    return false;
                return true;
            }
            return false;
        }
        public bool PROvalidaLote(string lote)
        {
            long x = 1;
            bool foi = long.TryParse(lote, out x);
            if (foi)
            {
                if (x <= 0 || x > 20)
                    return false;
                return true;
            }
            return false;
        }
        public bool PROvalidaQtd(string qtd)
        {
            long x = 1;
            bool foi = long.TryParse(qtd, out x);
            if (foi)
            {
                if (x <= 0)
                    return false;
                return true;
            }
            return false;
        }
        public bool PROvalidaLocal(string local)
        {
            if (local == "FRENTE" || local == "FUNDO")
            {
                return true;
            }
            return false;
        }
        #endregion

        #region INJEÇÃO
        public bool PROinjetar(long id, string name, double val, long lote, long qtd, string local)
        {
            try
            {
                Conexao acessoDados = new Conexao();

                string sql = "insert into Produto(ID_Produto,Prod_Nome,Prod_Valor,ID_Lote,Prod_Qtd,Prod_Local) values(@ID_Produto,@Prod_Nome,@Prod_Valor,@ID_Lote,@Prod_Qtd,@Prod_Local)";
                acessoDados.ExecutaNQ("insert into Produto(ID_Produto,Prod_Nome,Prod_Valor,ID_Lote) values('" + id + "','" + name + "','" + val + "','" + lote + "','" + qtd + "','" + local + "')");

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        #region ALTERAÇÃO
        public bool PROalterar(long id, string name, double val, long lote, long qtd, string local)
        {
            try
            {
                Conexao acessoDados = new Conexao();

                acessoDados.ExecutaNQ("UPDATE Produto SET Prod_Nome='" + name + "', Prod_Valor='" + val + "', ID_Lote='" + lote + "', Prod_Qtd='" + qtd + "', Prod_Local='" + local + "' WHERE Prod_Nome='" + name +"'");
                
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        #region EXCLUSÃO
        public bool PROexcluir(long id)
        {
            try
            {
                Conexao acessoDados = new Conexao();

                acessoDados.ExecutaNQ("DELETE FROM Produto WHERE ID_Prod=" + id + ")");

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        public void PesquisaProdutos(string pesquisa)
        {
                       
        }

        #endregion

        public DataSet selecionaProd()
        {
            Conexao AcessoDados = new Conexao();
            return AcessoDados.RetornaDataSet("Select * from Produto");
        }
    }
}
