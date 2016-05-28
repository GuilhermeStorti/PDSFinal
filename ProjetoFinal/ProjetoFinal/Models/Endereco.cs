using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Endereco
    {
        public Int64 idEndereco { get; set; }

        public String logradouro { get; set; }

        public Int32 numero { get; set; }

        public String bairro { get; set; }

        public String cidade { get; set; }

        public String estado { get; set; }

        public String complemento { get; set; }

        public String cep { get; set; }

    }
}
