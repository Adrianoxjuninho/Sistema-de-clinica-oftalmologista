using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_infuture.Model
{
    public class ReceitaMODEL
    {
        //CHAVE PRIMARIA 
        public int IdReceita { get; set; }

        public string longe_od_esferico { get; set; }
        public string longe_oe_esferico { get; set; }
        public string od_cilindrico { get; set; }
        public string oe_cilindrico { get; set; }
        public string od_eixo { get; set; }
        public string oe_eixo { get; set; }
        public string perto_od_esferico { get; set; }
        public string perto_oe_esferico { get; set; }
        public string perto_od_cilindrico { get; set; }
        public string perto_oe_cilindrico { get; set; }
        public string adicao { get; set; }
        public string observacoes { get; set; }
        public string ativo { get; set; }

        // CHAVES ESTRANGEIRAS
        public int IdCliente { get; set; }
        public int IdConsulta { get; set; }
    }
}
