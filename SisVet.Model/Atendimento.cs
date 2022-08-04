namespace SisVet.Model
{
    public class Atendimento
    {
        public int Id { get; set; }
        public int ClinicaId { get; set; }
        public int VeterinarioId { get; set; }
        public int AnimalId { get; set; }
        public string DataHora { get; set; }
        public int ProcedimentoId { get; set; }
    }
}
