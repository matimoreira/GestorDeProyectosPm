using System;
namespace GestionDeProyectosPM
{
	public class TaskEasy : Task
	{
		//Constructores
		public TaskEasy(){	}
		//Metodos
		public override float getHours()
		{
			return base.Estimate;
		}

	}
}

