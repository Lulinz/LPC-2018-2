using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Aula10_Avaliacao_G1.Models
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly DataContext context;
        public PacienteRepository (DataContext context)
        {
            this.context = context;

        }
        public void Create(Paciente paciente)
        {
            paciente.plano = context.planos.Find(paciente.plano.id);
            context.pacientes.Add(paciente);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Paciente> GetAll()
        {
            return context.pacientes.Include(x=>x.plano).ToList();
        }

        public Paciente GetById(int id)
        {
            return context
                        .pacientes
                        .Include(x=>x.plano)
                        .FirstOrDefault(x=>x.id == id);
        }

        public void Update(Paciente paciente)
        {
            var obj = GetById(paciente.id);
            obj.nome = paciente.nome;
            obj.endereco = paciente.endereco;
            obj.email = paciente.email;
            obj.fone = paciente.fone;
            obj.plano = paciente.plano;
            
            context.SaveChanges();
        }
    }
}