using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDeDados;

namespace CamadaDeNegocios
{
    public class Fornecedor
    {
        #region ATRIBUTOS
        public string FORnome { get; private set; }
        public string FORcnpj { get; private set; }
        public string FORnacl { get; private set; }
        public string FORnum { get; private set; }
        public string FORcep { get; private set; }
        public string FORrua { get; private set; }
        public string FORcomp { get; private set; }
        public string FORlog { get; private set; }
        #endregion

        #region CONSTRUTORES
        public Fornecedor()
        {
            FORnome = "";
            FORcnpj = "11.111.111/1111-11";
            FORnacl = "Brasil";
            FORcep = "11111-111";
            FORrua = "";
            FORcomp = "";
        }
        public Fornecedor(string nome,string cnpj, string nacl, string cep, string rua,string comp)
        {
            FORnome = nome;
            FORcnpj = cnpj;
            FORnacl = nacl;
            FORcep = cep;
            FORrua = rua;
            FORcomp = comp;
        }
        #endregion

        #region MÉTODOS

        #region inserir
        public bool FORinsereNome(string original)
        {
            if (FORvalidaNome(original))
            {
                FORnome = original;
                return true;
            }
            return false;
          
        }
        public bool FORinsereCNPJ(string original)
        {
            if (FORvalidaCNPJ(original))
            {
                FORnome = original;
                return true;
            }
            return false;
        }
        public bool FORinsereCEP(string cep)
        {
            if (FORvalidaCEP(cep))
            {
                FORcep = cep;
                return true;
            }
            return true;
        }
        public bool FORinsereNacio(string nacio)
        {
            if (!FORvalidaNacio(nacio))
            {
                FORnacl = nacio;
                return true;
            }
            return false;
        }
        public bool FORinsereRua(string rua)
        {
            if (FORvalidaRua(rua))
            {
                FORrua = rua;
                return true;
            }
            return false;
        }
        public bool FORinsereNum(string num)
        {
            if (FORvalidaNum(num))
            {
                FORnum = num;
                return true;
            }
            return false;
        }
        public bool FORinsereLog(string log)
        {
            if (FORvalidaLOG(log))
            {
                FORlog = log;
                return true;
            }
            return false;
        }
        public bool FORinsereCom(string comp)
        {
            FORcomp = comp;
            return true;
        }
        private DataSet FORverificaForn(string usuario)
        {

            Conexao acessoDados = new Conexao();
            return acessoDados.RetornaDataSet("SELECT Login_username FROM Login WHERE Login_username = '" + usuario + "'");

        }
        public bool FORcadastraForn(string name, string cnpj, string nac, string cep, string rua, string log, int num, string cpl)
        {
            DataSet aux = new DataSet();
            aux = this.FORverificaForn(name);
            if (aux.Tables[0].Rows.Count == 0)
            {
                Conexao acessoDados2 = new Conexao();
                acessoDados2.ExecutaNQ("insert into Fornecedor(Forn_cnpj,Forn_nome,Forn_nac,Forn_cep,Forn_log," +
                    "Forn_rua,Forn_nro,Forn_cpl) values('" + cnpj + "','" + name + "','" + nac + "','" + cep + "','" + log + "','" + rua + "', '" + num + "', '" + cpl + "')");
                return true;
            }
            else return false;

        }
#endregion

#region validar
public bool FORvalidaCNPJ(string cnpj)
        {
            string tempCNPJ = cnpj.Replace(",", "").Replace("-", "").Replace(".", "").Replace("/", "");

            if (tempCNPJ.Length != 14)
                return false;

            int A = int.Parse(tempCNPJ.Substring(0, 1)) * 5;
            int B = int.Parse(tempCNPJ.Substring(1, 1)) * 4;
            int C = int.Parse(tempCNPJ.Substring(2, 1)) * 3;
            int D = int.Parse(tempCNPJ.Substring(3, 1)) * 2;
            int E = int.Parse(tempCNPJ.Substring(4, 1)) * 9;
            int F = int.Parse(tempCNPJ.Substring(5, 1)) * 8;
            int G = int.Parse(tempCNPJ.Substring(6, 1)) * 7;
            int H = int.Parse(tempCNPJ.Substring(7, 1)) * 6;
            int I = int.Parse(tempCNPJ.Substring(8, 1)) * 5;
            int J = int.Parse(tempCNPJ.Substring(9, 1)) * 4;
            int K = int.Parse(tempCNPJ.Substring(10, 1)) * 3;
            int L = int.Parse(tempCNPJ.Substring(11, 1)) * 2;
            int M = int.Parse(tempCNPJ.Substring(12, 1));
            int N = int.Parse(tempCNPJ.Substring(13, 1));

            int soma = A + B + C + D + E + F + G + H + I + J + K + L;
            int resto = soma % 11;

            if ((resto < 2 && M == 0) || 11 - resto == M)
            {
                A = int.Parse(tempCNPJ.Substring(0, 1)) * 6;
                B = int.Parse(tempCNPJ.Substring(1, 1)) * 5;
                C = int.Parse(tempCNPJ.Substring(2, 1)) * 4;
                D = int.Parse(tempCNPJ.Substring(3, 1)) * 3;
                E = int.Parse(tempCNPJ.Substring(4, 1)) * 2;
                F = int.Parse(tempCNPJ.Substring(5, 1)) * 9;
                G = int.Parse(tempCNPJ.Substring(6, 1)) * 8;
                H = int.Parse(tempCNPJ.Substring(7, 1)) * 7;
                I = int.Parse(tempCNPJ.Substring(8, 1)) * 6;
                J = int.Parse(tempCNPJ.Substring(9, 1)) * 5;
                K = int.Parse(tempCNPJ.Substring(10, 1)) * 4;
                L = int.Parse(tempCNPJ.Substring(11, 1)) * 3;
                M *= 2;

                soma = A + B + C + D + E + F + G + H + I + J + K + L + M;
                resto = soma % 11;
                if ((resto < 2 && N == 0) || 11 - resto == N)
                    return true;
                else
                    return false;
            }
            else
                return false;
            /*int val = 0, k = 5, c = 0;
            for (int i = 12; i != 0; i--)
            {
                if (k < 2) k = 9;
                val = val + (int.Parse(cnpj.Substring(c, cnpj.Length - 13)) * k);
                k--;
                c++;
            }
            if (val % 11 < 2 && "0" == cnpj.Substring(c, cnpj.Length - 13))
            {
                k = 6; c = 0; val = 0;
                for (int i = 13; i != 0; i--)
                {
                    if (k < 2) k = 9;
                    val = val + (int.Parse(cnpj.Substring(c, cnpj.Length - 13)) * k);
                    k--;
                    c++;
                }
                if (val % 11 < 2 && "0" == cnpj.Substring(c, cnpj.Length - 13)) return true;
                if (11 - (val % 11) == int.Parse(cnpj.Substring(c, cnpj.Length - 13))) return true;
                return false;
            }
            else if ((11 - val % 11) == int.Parse(cnpj.Substring(c, cnpj.Length - 13)))
            {
                k = 6; c = 0; val = 0;
                for (int i = 13; i != 0; i--)
                {
                    if (k < 2) k = 9;
                    val = val + (int.Parse(cnpj.Substring(c, cnpj.Length - 13)) * k);
                    k--;
                    c++;
                }
                if (val % 11 < 2 && "0" == cnpj.Substring(c, cnpj.Length - 13)) return true;
                if (11 - (val % 11) == int.Parse(cnpj.Substring(c, cnpj.Length - 13))) return true;
                return false;
            }
            return false;*/
        }
        public bool FORvalidaNome(string nome)
        {
            nome = nome.Trim();
            return (nome.Length < 3) ? false : true;
        }
        public bool FORvalidaNacio(string nacio)
        {
            nacio = nacio.Trim();
            return nacio.Any(char.IsDigit) ?  false : true;
        }
        public bool FORvalidaRua(string rua)
        {
            rua = rua.Trim();
            return rua.Any(char.IsDigit) ? false : true;
        }
        private bool FORvalidaNum(string num)
        {
            int n;
            num = num.Trim();
            bool isNumeric = int.TryParse(num, out n);
            return isNumeric ? true : false;
        }
        public bool FORvalidaCEP(string cep)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}")) ? true : false;
        }
        private bool FORvalidaLOG(string log)
        {
            log = log.Trim();
            return log.Any(char.IsDigit) ? false : true;
        }
        #endregion

        #region INJEÇÃO
        public bool FORinjetar(CamadaDeNegocios.Fornecedor forn)
        {
            return true;
        }
        #endregion INJEÇÃO

        #endregion MÉTODOS
    }

}

