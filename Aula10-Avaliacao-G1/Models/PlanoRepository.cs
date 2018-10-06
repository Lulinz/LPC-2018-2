using System.Collections.Generic;
using System.Linq;

namespace Aula10_Avaliacao_G1.Models
{
    public class PlanoRepository : IPlanoRepository
    {
        private readonly DataContext context;
        public PlanoRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Plano plano)
        {
            context.planos.Add(plano);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.planos.Remove(context.planos.Find(id));
        }

        public List<Plano> GetAll()
        {
            return context.planos.ToList();
        }

        public Plano GetById(int id)
        {
            return context.planos.Find(id);
        }

        public void Update(Plano plano)
        {
            var obj = GetById(plano.id);
            obj.nome = plano.nome;

            context.SaveChanges();
        }
    }
}