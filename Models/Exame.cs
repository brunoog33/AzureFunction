using System;
using System.Collections.Generic;

namespace RES.Integracao.Exames.Function.Models
{
    public class Exame
    {
        public string Sessao { get; set; }

        public string CodigoExterno { get; set; }

        public string Nome { get; set; }

        public string Codigo { get; set; }

        public string Tipo { get; set; }

        public DateTime DataExecucao { get; set; }

        public string HoraExecucao { get; set; }

        public string SigilosoFlag { get; set; }

        public int BloqueadoFlag { get; set; }

        public int StatusLiberacao { get; set; }

        public DateTime DataLiberacao { get; set; }

        public string HoraLiberacao { get; set; }

        public int LaudoFlag { get; set; }

        public string CodigoPACS { get; set; }

        public string URLPACS { get; set; }

        public string Resultado { get; set; }

        public int Alterado { get; set; }

        public string Laudo { get; set; }

        public Paciente Paciente { get; set; }

        public Conveniado Conveniado { get; set; }

        public Medico MedicoSolicitante { get; set; }

        public Medico MedicoSolicitante2 { get; set; }

        public Medico MedicoExecutor { get; set; }

        public Medico MedicoLaudador { get; set; }

        public List<ExameItem> ItensExame { get; set; }
    }
}