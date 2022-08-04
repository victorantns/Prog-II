using System.Collections.Generic;

namespace SisVet.Model
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int EnderecoId { get; set; }
        //Navigation Property

        public ICollection<Atendimento> Atendimentos { get; set; }
        = new List<Atendimento>();

    }
}
