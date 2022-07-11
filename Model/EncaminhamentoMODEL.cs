using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_infuture.Model
{
    public class EncaminhamentoMODEL
    {
        // CHAVE PRIMARIA
        public int IdEncaminhamento { get; set; }

        public string observacoes { get; set; }
        public string ativo { get; set; }

        // CHAVES ESTRANGEIRAS
        public int IdCliente { get; set; }
        public int IdConsulta { get; set; }
    }
}
