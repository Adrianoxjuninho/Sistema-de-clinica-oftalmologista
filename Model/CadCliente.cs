using System;

namespace system_infuture.Model
{
    public class CadCliente
    {
        public int ID_Paciente { get; set; }
        public string nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime Dt_Nascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }
        public string Endereco { get; set; }
        public string Observacoes { get; set; }

        public int id_login { get; set; }
    }
}
