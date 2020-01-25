using System;
using System.Collections.Generic;
using System.Text;

namespace GestionDeProyectosPM
{
    class TaskComplicated: Task
    {
		//Constructores
		public TaskComplicated() { }
		//Metodos
		public override float getHours()
		{
			return base.Estimate * 1.20F;
		}
	}
}
