using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDeDados;

namespace CamadaDeNegocios
{
    public class Consumidor
    {
        public Consumidor()
        {
            this.CONcpf = "";
            this.CONcpf = "";
        }

        public Consumidor(string nome, string cpf)
        {
            this.CONnome = nome;
            this.CONcpf = cpf;
        }

        public bool CONcadastraConsum(string name, string cpf)
        {
            bool flag2;
            DataSet set = new DataSet();
            if (this.CONverificaConsum(name).Tables[0].Rows.Count != 0)
            {
                flag2 = false;
            }
            else
            {
                string[] textArray1 = new string[] { "insert into Consumidor(ID_CPF,Cons_Nome) values('", cpf, "','", name, "')" };
                new Conexao().ExecutaNQ(string.Concat(textArray1));
                flag2 = true;
            }
            return flag2;
        }

        public DataTable CONconsultarConsumidor(string cons)
        {
            DataTable tb = new DataTable();
            try
            {
                Conexao conexao = new Conexao();
                return ((cons == "0") ? conexao.retornaAdapterTB("SELECT * FROM Consumidor", tb) : conexao.retornaAdapterTB("SELECT * FROM Consumidor WHERE Cons_Nome LIKE  '%" + cons.ToUpper() + "%'", tb));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool CONinjetar(Produto prod) =>
            true;

        public bool CONinsereCPF(string original)
        {
            bool flag2;
            if (!this.CONvalidaCPF(original))
            {
                flag2 = false;
            }
            else
            {
                this.CONcpf = original;
                flag2 = true;
            }
            return flag2;
        }

        public bool CONinsereNome(string nome)
        {
            bool flag2;
            if (!this.CONvalidaNome(nome))
            {
                flag2 = false;
            }
            else
            {
                this.CONnome = nome;
                flag2 = true;
            }
            return flag2;
        }

        public bool CONvalidaCPF(string cpf)
        {
            bool flag2;
            string str = cpf.Replace(",", "").Replace("-", "").Replace(".", "");
            if (str.Length != 11)
            {
                flag2 = false;
            }
            else
            {
                int num3 = int.Parse(str.Substring(2, 1)) * 8;
                int num4 = int.Parse(str.Substring(3, 1)) * 7;
                int num5 = int.Parse(str.Substring(4, 1)) * 6;
                int num6 = int.Parse(str.Substring(5, 1)) * 5;
                int num7 = int.Parse(str.Substring(6, 1)) * 4;
                int num8 = int.Parse(str.Substring(7, 1)) * 3;
                int num9 = int.Parse(str.Substring(8, 1)) * 2;
                int num10 = int.Parse(str.Substring(9, 1));
                int num11 = int.Parse(str.Substring(10, 1));
                int num13 = (((((((((int.Parse(str.Substring(0, 1)) * 10) + (int.Parse(str.Substring(1, 1)) * 9)) + num3) + num4) + num5) + num6) + num7) + num8) + num9) % 11;
                if (!(((num13 >= 2) || (num10 != 0)) ? ((11 - num13) == num10) : true))
                {
                    flag2 = false;
                }
                else
                {
                    num3 = int.Parse(str.Substring(2, 1)) * 9;
                    num4 = int.Parse(str.Substring(3, 1)) * 8;
                    num5 = int.Parse(str.Substring(4, 1)) * 7;
                    num6 = int.Parse(str.Substring(5, 1)) * 6;
                    num7 = int.Parse(str.Substring(6, 1)) * 5;
                    num8 = int.Parse(str.Substring(7, 1)) * 4;
                    num9 = int.Parse(str.Substring(8, 1)) * 3;
                    num10 *= 2;
                    num13 = ((((((((((int.Parse(str.Substring(0, 1)) * 11) + (int.Parse(str.Substring(1, 1)) * 10)) + num3) + num4) + num5) + num6) + num7) + num8) + num9) + num10) % 11;
                    flag2 = ((num13 >= 2) || (num11 != 0)) ? ((11 - num13) == num11) : true;
                }
            }
            return flag2;
        }

        public int CONvalidaLetraNome(char e) =>
            (((char.IsLetter(e) || (e == '\b')) || (e == ' ')) ? 1 : 0);

        public bool CONvalidaNome(string nome) =>
            (nome.Trim().Length >= 3);

        private DataSet CONverificaConsum(string usuario) =>
            new Conexao().RetornaDataSet("SELECT Login_username FROM Login WHERE Login_username = '" + usuario + "'");

        public string CONnome { get; private set; }

        public string CONcpf { get; private set; }
    }
}
