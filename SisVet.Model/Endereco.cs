namespace SisVet.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Nro { get; set; }
        public int Complemento { get; set; }
        public int Bairro { get; set; }
        public int Cidade { get; set; }
        public Estado Estado { get; set; }
        public int Pais { get; set; }
        public int Cep { get; set; }

    }

    public enum Estado {
        AC, AL, AM, AP, BA, CE, DF, ES, GO, MA, MG, 
        MS, MT, PA, PB, PE, PI, PR, RJ, RN, RO, RR, 
        RS, SC, SE, SP, TO

    }
}
