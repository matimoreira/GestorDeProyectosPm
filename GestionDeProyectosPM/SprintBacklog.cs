using System;
using System.Collections.Generic;
namespace GestionDeProyectosPM
{
    public class SprintBacklog
    {
        //Campos
        private List<Task> _tasks;


        //Contructores
        public SprintBacklog()
        {
            _tasks = new List<Task>();
        }


        //Metodos
        public void addTask(Task value)
        {
            _tasks.Add(value);
        }

        public List<Task> getAllTasks()
        {
            return _tasks;
        }

        public float getHours()
        {
            float hours = 0;
            foreach (var task in _tasks)
            {
                hours += task.getHours();
            }
            return hours;
        }
        
    }
}