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
    public class Fornecedor
    {
        public Fornecedor()
        {
            this.FORnome = "";
            this.FORcnpj = "11.111.111/1111-11";
            this.FORnacl = "Brasil";
            this.FORcep = "11111-111";
            this.FORrua = "";
            this.FORcomp = "";
        }

        public Fornecedor(string nome, string cnpj, string nacl, string cep, string rua, string comp)
        {
            this.FORnome = nome;
            this.FORcnpj = cnpj;
            this.FORnacl = nacl;
            this.FORcep = cep;
            this.FORrua = rua;
            this.FORcomp = comp;
        }

        public DataTable ConsultaFornos(string inv)
        {
            DataTable tb = new DataTable();
            try
            {
                Conexao conexao = new Conexao();
                return ((inv == "0") ? conexao.retornaAdapterTB("SELECT * FROM Fornecedor", tb) : conexao.retornaAdapterTB("SELECT * FROM Fornecedor WHERE Forn_nome LIKE '%" + inv.ToUpper() + "%'", tb));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool FORcadastraForn(string name, string cnpj, string nac, string cep, string rua, string log, int num, string cpl)
        {
            bool flag2;
            DataSet set = new DataSet();
            if (this.FORverificaForn(name).Tables[0].Rows.Count != 0)
            {
                flag2 = false;
            }
            else
            {
                object[] objArray1 = new object[0x11];
                objArray1[0] = "insert into Fornecedor(Forn_cnpj,Forn_nome,Forn_nac,Forn_cep,Forn_log,Forn_rua,Forn_nro,Forn_cpl) values('";
                objArray1[1] = cnpj;
                objArray1[2] = "','";
                objArray1[3] = name;
                objArray1[4] = "','";
                objArray1[5] = nac;
                objArray1[6] = "','";
                objArray1[7] = cep;
                objArray1[8] = "','";
                objArray1[9] = log;
                objArray1[10] = "','";
                objArray1[11] = rua;
                objArray1[12] = "', '";
                objArray1[13] = num;
                objArray1[14] = "', '";
                objArray1[15] = cpl;
                objArray1[0x10] = "')";
                new Conexao().ExecutaNQ(string.Concat(objArray1));
                flag2 = true;
            }
            return flag2;
        }

        public DataTable FORconsultaForno(string forno)
        {
            DataTable tb = new DataTable();
            try
            {
                Conexao conexao = new Conexao();
                return ((forno == "0") ? conexao.retornaAdapterTB("SELECT * FROM Fornecedor", tb) : conexao.retornaAdapterTB("SELECT * FROM Fornecedor WHERE Forn_nome LIKE '%" + forno + "%'", tb));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool FORinjetar(Fornecedor forn) =>
            true;

        public bool FORinsereCEP(string cep)
        {
            bool flag2;
            if (!this.FORvalidaCEP(cep))
            {
                flag2 = true;
            }
            else
            {
                this.FORcep = cep;
                flag2 = true;
            }
            return flag2;
        }

        public bool FORinsereCNPJ(string original)
        {
            bool flag2;
            if (!this.FORvalidaCNPJ(original))
            {
                flag2 = false;
            }
            else
            {
                this.FORnome = original;
                flag2 = true;
            }
            return flag2;
        }

        public bool FORinsereCom(string comp)
        {
            this.FORcomp = comp;
            return true;
        }

        public bool FORinsereLog(string log)
        {
            bool flag2;
            if (!this.FORvalidaLOG(log))
            {
                flag2 = false;
            }
            else
            {
                this.FORlog = log;
                flag2 = true;
            }
            return flag2;
        }

        public bool FORinsereNacio(string nacio)
        {
            bool flag2;
            if (this.FORvalidaNacio(nacio))
            {
                flag2 = false;
            }
            else
            {
                this.FORnacl = nacio;
                flag2 = true;
            }
            return flag2;
        }

        public bool FORinsereNome(string original)
        {
            bool flag2;
            if (!this.FORvalidaNome(original))
            {
                flag2 = false;
            }
            else
            {
                this.FORnome = original;
                flag2 = true;
            }
            return flag2;
        }

        public bool FORinsereNum(string num)
        {
            bool flag2;
            if (!this.FORvalidaNum(num))
            {
                flag2 = false;
            }
            else
            {
                this.FORnum = num;
                flag2 = true;
            }
            return flag2;
        }

        public bool FORinsereRua(string rua)
        {
            bool flag2;
            if (!this.FORvalidaRua(rua))
            {
                flag2 = false;
            }
            else
            {
                this.FORrua = rua;
                flag2 = true;
            }
            return flag2;
        }

        public bool FORvalidaCEP(string cep) =>
            Regex.IsMatch(cep, "[0-9]{5}-[0-9]{3}");

        public bool FORvalidaCNPJ(string cnpj)
        {
            bool flag2;
            string str = cnpj.Replace(",", "").Replace("-", "").Replace(".", "").Replace("/", "");
            if (str.Length != 14)
            {
                flag2 = false;
            }
            else
            {
                int num3 = int.Parse(str.Substring(2, 1)) * 3;
                int num4 = int.Parse(str.Substring(3, 1)) * 2;
                int num5 = int.Parse(str.Substring(4, 1)) * 9;
                int num6 = int.Parse(str.Substring(5, 1)) * 8;
                int num7 = int.Parse(str.Substring(6, 1)) * 7;
                int num8 = int.Parse(str.Substring(7, 1)) * 6;
                int num9 = int.Parse(str.Substring(8, 1)) * 5;
                int num10 = int.Parse(str.Substring(9, 1)) * 4;
                int num11 = int.Parse(str.Substring(10, 1)) * 3;
                int num12 = int.Parse(str.Substring(11, 1)) * 2;
                int num13 = int.Parse(str.Substring(12, 1));
                int num14 = int.Parse(str.Substring(13, 1));
                int num16 = ((((((((((((int.Parse(str.Substring(0, 1)) * 5) + (int.Parse(str.Substring(1, 1)) * 4)) + num3) + num4) + num5) + num6) + num7) + num8) + num9) + num10) + num11) + num12) % 11;
                if (!(((num16 >= 2) || (num13 != 0)) ? ((11 - num16) == num13) : true))
                {
                    flag2 = false;
                }
                else
                {
                    num3 = int.Parse(str.Substring(2, 1)) * 4;
                    num4 = int.Parse(str.Substring(3, 1)) * 3;
                    num5 = int.Parse(str.Substring(4, 1)) * 2;
                    num6 = int.Parse(str.Substring(5, 1)) * 9;
                    num7 = int.Parse(str.Substring(6, 1)) * 8;
                    num8 = int.Parse(str.Substring(7, 1)) * 7;
                    num9 = int.Parse(str.Substring(8, 1)) * 6;
                    num10 = int.Parse(str.Substring(9, 1)) * 5;
                    num11 = int.Parse(str.Substring(10, 1)) * 4;
                    num12 = int.Parse(str.Substring(11, 1)) * 3;
                    num13 *= 2;
                    num16 = (((((((((((((int.Parse(str.Substring(0, 1)) * 6) + (int.Parse(str.Substring(1, 1)) * 5)) + num3) + num4) + num5) + num6) + num7) + num8) + num9) + num10) + num11) + num12) + num13) % 11;
                    flag2 = ((num16 >= 2) || (num14 != 0)) ? ((11 - num16) == num14) : true;
                }
            }
            return flag2;
        }

        private bool FORvalidaLOG(string log)
        {
            log = log.Trim();
            return !log.Any<char>(new Func<char, bool>(char.IsDigit));
        }

        public bool FORvalidaNacio(string nacio)
        {
            nacio = nacio.Trim();
            return !nacio.Any<char>(new Func<char, bool>(char.IsDigit));
        }

        public bool FORvalidaNome(string nome)
        {
            nome = nome.Trim();
            return (nome.Length >= 3);
        }

        private bool FORvalidaNum(string num)
        {
            int num2;
            num = num.Trim();
            return int.TryParse(num, out num2);
        }

        public bool FORvalidaRua(string rua)
        {
            rua = rua.Trim();
            return !rua.Any<char>(new Func<char, bool>(char.IsDigit));
        }

        private DataSet FORverificaForn(string usuario) =>
            new Conexao().RetornaDataSet("SELECT Login_username FROM Login WHERE Login_username = '" + usuario + "'");

        public string FORnome { get; private set; }

        public string FORcnpj { get; private set; }

        public string FORnacl { get; private set; }

        public string FORnum { get; private set; }

        public string FORcep { get; private set; }

        public string FORrua { get; private set; }

        public string FORcomp { get; private set; }

        public string FORlog { get; private set; }
    }
}

