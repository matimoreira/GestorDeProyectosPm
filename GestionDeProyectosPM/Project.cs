using System;
using System.Collections.Generic;
namespace GestionDeProyectosPM
{
    public class Project
    {
		//Campos
        private List<SprintBacklog> _SprintsBacklogs;


		//Constructores
		public Project()
        {
            _SprintsBacklogs = new List<SprintBacklog>();
        }


		//Metodos
		public void addSprintBacklog(SprintBacklog value)
        {
            _SprintsBacklogs.Add(value);
        }

		public List<SprintBacklog> getAllSprintsBacklogs()
        {
            return _SprintsBacklogs;
        }

		public float getHours()
        {
            float _hours = 0;
            foreach (var sprint in _SprintsBacklogs)
            {
                _hours += sprint.getHours();
            }
            return _hours;
        }


    }
}