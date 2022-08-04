using System;
using SisVet.Repository;
using SisVet.Model;

namespace SisVet.Repository
{
    public class VeterinarioRepository
    {
        public bool Salvar(VeterinarioRepository veterinario)
        {
            return true;
        }

        public Veterinario Retornar(int veterinarioId)
        {
            Veterinario veterinario = new Veterinario(veterinarioId);

            // Buscar dados do Banco de Dados

            if (veterinarioId == 1)
            {
                veterinario.Nome = "Victor";
            }

            return veterinario;

        }
    }
   
}
