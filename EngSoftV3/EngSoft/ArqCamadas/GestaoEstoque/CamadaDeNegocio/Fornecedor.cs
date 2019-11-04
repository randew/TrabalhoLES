using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        #endregion

        #region validar
        public bool FORvalidaCNPJ(string cnpj)
        {
            int val = 0, k = 5, c = 0;
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
            return false;
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

