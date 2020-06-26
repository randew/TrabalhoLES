using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEstoque
{
    class Consumidor
    {
        #region ATRIBUTOS
        public string CONnome { get; private set; }
        public string CONcpf { get; private set; }
        #endregion

        #region CONSTRUTORES
        public Consumidor(string nome,string cpf)
        {
            this.CONnome = nome;
            this.CONcpf = cpf;
        }
        public Consumidor()
        {
            this.CONcpf = "";
            this.CONcpf = "";
        }
        #endregion

        #region MÉTODOS

        public bool CONinsereCPF(string original)
        {//insere o cpf
            if (CONvalidaCPF(original))
            {
                CONcpf = original;
                return true;
            }
            return false;

        } 

        public bool CONinsereNome(string nome)
        { //Insere o nome
            if (CONvalidaNome(nome))
            {
                CONnome = nome;
                return true;
            }
            return false;
        }

        public bool CONvalidaCPF(string cpf)
        {
            string tempCPF = cpf.Replace(",", "").Replace("-", "").Replace(".", "");

            if (tempCPF.Length != 11)
                return false;

            int A = int.Parse(tempCPF.Substring(0, 1)) * 10;
            int B = int.Parse(tempCPF.Substring(1, 1)) * 9;
            int C = int.Parse(tempCPF.Substring(2, 1)) * 8;
            int D = int.Parse(tempCPF.Substring(3, 1)) * 7;
            int E = int.Parse(tempCPF.Substring(4, 1)) * 6;
            int F = int.Parse(tempCPF.Substring(5, 1)) * 5;
            int G = int.Parse(tempCPF.Substring(6, 1)) * 4;
            int H = int.Parse(tempCPF.Substring(7, 1)) * 3;
            int I = int.Parse(tempCPF.Substring(8, 1)) * 2;
            int J = int.Parse(tempCPF.Substring(9, 1));
            int K = int.Parse(tempCPF.Substring(10, 1));

            int soma = A + B + C + D + E + F + G + H + I;
            int resto = soma % 11;

            if ((resto < 2 && J == 0) || 11 - resto == J)
            {
                A = int.Parse(tempCPF.Substring(0, 1)) * 11;
                B = int.Parse(tempCPF.Substring(1, 1)) * 10;
                C = int.Parse(tempCPF.Substring(2, 1)) * 9;
                D = int.Parse(tempCPF.Substring(3, 1)) * 8;
                E = int.Parse(tempCPF.Substring(4, 1)) * 7;
                F = int.Parse(tempCPF.Substring(5, 1)) * 6;
                G = int.Parse(tempCPF.Substring(6, 1)) * 5;
                H = int.Parse(tempCPF.Substring(7, 1)) * 4;
                I = int.Parse(tempCPF.Substring(8, 1)) * 3;
                J *= 2;

                soma = A + B + C + D + E + F + G + H + I + J;
                resto = soma % 11;
                if ((resto < 2 && K == 0) || 11 - resto == K)
                    return true;
                else
                    return false;
            }
            else
                return false;
        } //valida o cpf

        public int CONvalidaLetraNome(char e) //verifica letra por letra do nome
        {
            if ((!Char.IsLetter(e) && e != (Char)8) && e != (Char)32)
            {
                return 0;
            }
            else
                return 1;
        }

        public bool CONvalidaNome(string nome) //verifica o nome inteiro a fim de evitar nomes em branco ou menores de 3 caracteres
        {
            string tempNome = nome.Trim();
            if (tempNome.Length < 3)
                return false;
            return true;
        }
       
        #endregion
    }
}
