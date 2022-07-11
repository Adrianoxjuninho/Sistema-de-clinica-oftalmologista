using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_infuture.Model
{
    public class CadUsersMODEL
    {
        // Chave Primaria da tabela de login
        public int Id_login { get; set; }

        public string usuario { get; set; }
        public string senha { get; set; }
        public string tipo_usuario { get; set; }
    }
}
