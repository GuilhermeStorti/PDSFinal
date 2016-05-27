using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Produto
    {

        public long idProduto { get; set; }

        public String descricao { get; set; }

        public float valor { get; set; }

        public long idTipoProduto { get; set; }

        public String estoque { get; set; }

        public long idFabricante { get; set; }

    }
}
