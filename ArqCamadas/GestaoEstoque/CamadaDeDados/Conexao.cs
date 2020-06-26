using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace CamadaDeDados
{
    public class Conexao
    {
        OleDbConnection myBDConnection = new OleDbConnection(Properties.Settings.Default.padokaBDConnectionString);

        public void abrirConexao()
        {
            myBDConnection.Open();
        }

        public void fecharConexao()
        {
            myBDConnection.Close();
        }

        public DataSet RetornaDataSet(string sql)
        {
            try
            {
                abrirConexao();
                OleDbDataAdapter oDa = new OleDbDataAdapter(sql, myBDConnection);
                DataSet oDs = new DataSet();
                oDa.Fill(oDs);
                fecharConexao();
                return oDs;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ExecutaNQ(string sql)
        {
            abrirConexao();
            OleDbCommand command = new OleDbCommand(sql, myBDConnection);
            command.ExecuteNonQuery();
            fecharConexao();
        }
    }
}
