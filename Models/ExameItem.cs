using System;

namespace RES.Integracao.Exames.Function.Models
{
    public class ExameItem
    {
        public string Codigo { get; set; }

        public string Nome { get; set; }

        public string ValorRefMin { get; set; }

        public string ValorRefMax { get; set; }

        public string ValorResultado { get; set; }

        public string UnidadeMedida { get; set; }

        public int Alterado { get; set; }

    }
}