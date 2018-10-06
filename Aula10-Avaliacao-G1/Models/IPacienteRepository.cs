using System.Collections.Generic;

namespace Aula10_Avaliacao_G1.Models
{
    public interface IPacienteRepository
    {
        void Create(Paciente paciente);
        List<Paciente> GetAll();
        void Update(Paciente paciente);
        Paciente GetById(int id);
        void Delete(int id);
    }
}