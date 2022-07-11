namespace system_infuture.Model
{
    public class AvalicaoMODEL
    {
        //CHAVE PRIMARIA 
        public int IdAnamnese { get; set; }

        public string m_p_c { get; set; }
        public string ant_Pessoais { get; set; }
        public string ant_Familiar { get; set; }
        public string oD_Esferico { get; set; }
        public string oE_Esferico { get; set; }
        public string oD_Cilindrico { get; set; }
        public string oE_Cilindrico { get; set; }
        public string oD_Eixo { get; set; }
        public string oE_Eixo { get; set; }
        public string adicao { get; set; }
        public string oD_Av { get; set; }
        public string oD_P_P { get; set; }
        public string oE_Av { get; set; }
        public string oE_P_P { get; set; }
        public string oD_CC { get; set; }
        public string oD_P_P_CC { get; set; }
        public string oE_CC { get; set; }
        public string oE_P_P_CC { get; set; }
        public string seg_Posterior { get; set; }
        public string seg_Anterior { get; set; }
        public string ativo { get; set; }

        //CHAVE ESTRANGEIRA DO CLIENTE E DA CONSULTA
        public int IdCliente { get; set; }
        public int IdConsulta { get; set; }
        public string status { get; set; }
    }
}
