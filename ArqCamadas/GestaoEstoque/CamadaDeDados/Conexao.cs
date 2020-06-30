using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using CamadaDeDados.Properties;

namespace CamadaDeDados
{
    public class Conexao
    {
        private OleDbConnection myBDConnection = new OleDbConnection(Settings.Default.padokaBDConnectionString);

        public void abrirConexao()
        {
            this.myBDConnection.Open();
        }

        public void ExecutaNQ(string sql)
        {
            this.abrirConexao();
            new OleDbCommand(sql, this.myBDConnection).ExecuteNonQuery();
            this.fecharConexao();
        }

        public void fecharConexao()
        {
            this.myBDConnection.Close();
        }

        public DataTable retornaAdapterTB(string sql, DataTable tb)
        {
            DataTable table;
            try
            {
                this.abrirConexao();
                new OleDbDataAdapter(new OleDbCommand(sql, this.myBDConnection)).Fill(tb);
                this.fecharConexao();
                table = tb;
            }
            catch (Exception)
            {
                throw;
            }
            return table;
        }

        public DataSet RetornaDataSet(string sql)
        {
            DataSet set2;
            try
            {
                this.abrirConexao();
                DataSet dataSet = new DataSet();
                new OleDbDataAdapter(sql, this.myBDConnection).Fill(dataSet);
                this.fecharConexao();
                set2 = dataSet;
            }
            catch (Exception)
            {
                throw;
            }
            return set2;
        }
    }
}
