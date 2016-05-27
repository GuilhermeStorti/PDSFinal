using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class ProdutoPedido
    {

        public long idProduto { get; set; }

        public long idPedido { get; set; }

        public Int32 quantidade { get; set; }

        public float valorParcial { get; set; }

    }
}
