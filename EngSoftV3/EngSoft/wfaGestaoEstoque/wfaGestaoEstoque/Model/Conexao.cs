using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace wfaGestaoEstoque.Model
{
    class Conexao
    {
        String StrCon = "";
        SqlConnection Conx = new SqlConnection();
        
        public void AbrirConexao(){
            Conx.ConnectionString = StrCon;
            Conx.Open();
        }
        public void FecharConexao(){
            Conx.Close();
        }
        public void ExecutarPRO(){

        }
    }
}
