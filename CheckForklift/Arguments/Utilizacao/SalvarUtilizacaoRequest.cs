using System;

namespace CheckForklift.Arguments.Utilizacao
{
    public class SalvarUtilizacaoRequest
    {
        public string Imei { get; set; }
        public int IdUtilizacao { get; set; }
        public int IdVeiculo { get; set; }
        public string User { get; set; }
        public DateTime InicioUtilizacao { get; set; }
        public DateTime FimUtilizacao { get; set; }
        public long LocationInic_X { get; set; }
        public long LocationIni_Y { get; set; }
        public long LocationFim_X { get; set; }
        public long LocationFim_Y { get; set; }
    }
}
