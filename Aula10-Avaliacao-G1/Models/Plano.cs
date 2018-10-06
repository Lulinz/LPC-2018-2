namespace Aula10_Avaliacao_G1.Models
{
    public class Plano
    {
        public Plano(){}

        public Plano(int id, string nome)
        {
            this.id = id;
            this.nome = nome;

        }

        public int id { get; set; }
        public string nome { get; set; }
    }
}