using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Pedido
    {

        public long idPedido { get; set; }

        public DateTime dataVenda { get; set; }

        public float valor { get; set; }

        public long idStatus { get; set; }

        public long idCliente { get; set; }

        public long idUsuario { get; set; }

        public long idFormaPagamento { get; set; }

        public DateTime dataPagamento { get; set; }

    }
}
