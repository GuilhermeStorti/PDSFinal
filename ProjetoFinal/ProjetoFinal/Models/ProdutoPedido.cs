using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class ProdutoPedido
    {

        public Int64 idProduto { get; set; }

        public Int64 idPedido { get; set; }

        public Int32 quantidade { get; set; }

        public float valorParcial { get; set; }

    }
}
