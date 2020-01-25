using System;
using System.Collections.Generic;
using System.Text;

namespace GestionDeProyectosPM
{
    class TaskSuperComplicated : Task 
    {
        public TaskSuperComplicated() { }

        //Metodos
        public override float getHours()
        {
            return base.Estimate * 1.50F;
        }
    }
}
