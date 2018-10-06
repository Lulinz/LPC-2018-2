using System;

namespace Aula10_Avaliacao_G1.Models
{
    public class Consulta
    {
        public Consulta(){}
        
        public Consulta(int id, DateTime dataHora, string oQueFoiFeito, decimal valorConsulta, string oQueFoiFeitoRevisao, Paciente paciente)
        {
            this.id = id;
            this.dataHora = dataHora;
            this.oQueFoiFeito = oQueFoiFeito;
            this.valorConsulta = valorConsulta;
            this.oQueFoiFeitoRevisao = oQueFoiFeitoRevisao;
            this.paciente = paciente;

        }
        public int id { get; set; }
        public DateTime dataHora { get; set; }
        public string oQueFoiFeito { get; set; }
        public decimal valorConsulta { get; set; }

        public DateTime? dataRevisao { get; set; }
        public string oQueFoiFeitoRevisao { get; set; }

        public Paciente paciente { get; set; }


    }
}