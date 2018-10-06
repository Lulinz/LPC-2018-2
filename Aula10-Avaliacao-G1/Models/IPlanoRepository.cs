using System.Collections.Generic;

namespace Aula10_Avaliacao_G1.Models
{
    public interface IPlanoRepository
    {
        void Create(Plano plano);
        List<Plano> GetAll();
        void Update(Plano plano);
        Plano GetById(int id);
        void Delete(int id);
    }    
}