using System;

namespace system_infuture.Model
{
    public class Agendamento
    {
        public int id_consulta { get; set; }

        public DateTime dt_consulta { get; set; }
        public DateTime horario { get; set; }
        public string retorno { get; set; }
        public string motivo_consulta { get; set; }
        public string ativo { get; set; }

        //Chave estrangeiras
        public int id_cliente { get; set; }
        public int id_medico { get; set; }
    }
}
