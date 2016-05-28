using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Produto
    {

        public Int64 idProduto { get; set; }

        public String descricao { get; set; }

        public float valor { get; set; }

        public Int64 idTipoProduto { get; set; }

        public String estoque { get; set; }

        public Int64 idFabricante { get; set; }

    }
}
