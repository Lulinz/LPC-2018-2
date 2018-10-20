using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.Domain;
using ToDoList.Repositories.Data;
using ToDoList.Repositories.Interfaces;

namespace ToDoList.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private DataContext dataContext;
        public ToDoRepository(DataContext dataContext)
        {           
            this.dataContext = dataContext;
        }

        public void Create(ToDo person)
        {
            dataContext.Add(person);
            dataContext.SaveChanges();
        }
        public List<ToDo> GetAll()
        {
            return dataContext.todos.ToList();
        }
        
        public void Update(ToDo todo)
        {
            var obj  = GetById(todo.id);
            
            obj.descricao = todo.descricao;
            
            
            
            dataContext.SaveChanges();
        }
        public ToDo GetById(int id)
        {
            return dataContext.todos.SingleOrDefault(x=>x.id == id);
        }
        
        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }

    }
}
