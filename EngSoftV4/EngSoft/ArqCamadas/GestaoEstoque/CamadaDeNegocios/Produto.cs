using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEstoque
{
    class Produto
    {
        public string PROnome { get; protected set; }
        public double PROvalor { get; protected set; }
        public string PROtipo { get; set; }
        public string PROfornecedor { get; set; }
    }
}
