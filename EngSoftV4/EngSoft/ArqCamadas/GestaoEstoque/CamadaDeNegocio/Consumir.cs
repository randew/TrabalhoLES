using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDeNegocio
{
    public class Consumir
    {
        #region ATRIBUTOS
        public string CONSid { get; private set; }
        public double CONSvalor { get; private set; }
        #endregion ATRIBUTOS

        #region CONSTRUTORES
        public Consumir()
        {
            this.CONSid = "";
        }
        public Consumir(string id)
        {
            CONSid = id;
        }
        #endregion CONSTRUTORES

        #region MÉTODOS
        public int CONSokok(int hue)
        {
            return hue;
        }
        #region INJEÇÃO
         public bool CONSinjetar(Consumir compra)
         {
             return true;
         }
        #endregion
        #endregion MÉTODOS
    }
}
