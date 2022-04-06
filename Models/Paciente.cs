using System;

namespace RES.Integracao.Exames.Function.Models
{
    public class Paciente
    {
        public string Codigo { get; set; }

        public string Nome { get; set; }

        public string Sexo { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Bloqueado { get; set; }

        public string Documento { get; set; }

        public string CPF { get; set; }
    }
}