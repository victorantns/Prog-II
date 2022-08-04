using System.Collections.Generic;

namespace SisVet.Model
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DataNascimento { get; set; }

        public string Peso { get; set; }

        public string Altura { get; set; }

        public string Comprimento { get; set; }

        public string Cor { get; set; }

        public int RacaId { get; set; }

        public int TipoAnimalId { get; set; }

        public Raca Raca { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }

        public ICollection<Atendimento> Atendimentos { get; set; }
        = new List<Atendimento>();

    }
}
