using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Pedido
    {

        public Int64 idPedido { get; set; }

        public DateTime dataVenda { get; set; }

        public float valor { get; set; }

        public Int64 idStatus { get; set; }

        public Int64 idCliente { get; set; }

        public Int64 idUsuario { get; set; }

        public Int64 idFormaPagamento { get; set; }

        public DateTime dataPagamento { get; set; }

    }
}
