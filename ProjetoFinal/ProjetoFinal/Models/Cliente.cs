using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Cliente
    {
        public Int64 idCliente { get; set; }

        public String nome { get; set; }

        public String telefone { get; set; }

        public String email { get; set; }

        public String cpf { get; set; }

        public Int64 idEndereco { get; set; }

    }
}
