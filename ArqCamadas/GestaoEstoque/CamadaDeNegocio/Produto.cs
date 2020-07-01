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

<<<<<<< Updated upstream
        }

        public bool PROinserirNome(string nome)
=======
        public bool PROalterar(string name, double val, long lote, long qtd, string local, long id)
>>>>>>> Stashed changes
        {
            if (PROvalidaNome(nome))
            {
<<<<<<< Updated upstream
                PROnome = nome;
=======
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
                objArray1[10] = "' WHERE ID_Produto='";
                objArray1[11] = id;
                objArray1[12] = "'";
                new Conexao().ExecutaNQ(string.Concat(objArray1));
>>>>>>> Stashed changes
                return true;
            }
            return false;
        }
        public bool PROinserirPreco(string valor)
        {
            if (PROvalidaPreco(valor))
            {
<<<<<<< Updated upstream
                PROvalor = double.Parse(valor);
=======
                new Conexao().ExecutaNQ(("DELETE FROM Produto WHERE ID_Prod=" + id + ""));
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
                PROqtd = int.Parse(qtd);
=======
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
>>>>>>> Stashed changes
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
