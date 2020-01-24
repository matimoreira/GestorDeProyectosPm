using System;
namespace GestionDeProyectosPM
{
    public class Task
    {
        //Propiedadades
        public int Estimate { get; set; }

        public UserStory UserStory { get; set; }

        public Difficulty Difficulty { get; set; }


        //Metodos
        public float getHours()
        {
            switch (Difficulty)
	        {
                case Difficulty.easy:
                    return Estimate;
                    break;
                case Difficulty.compliacted:
                    return Estimate * 1.2F;
                    break;
                case Difficulty.superComplicated:
                    return Estimate* 1.5F;
                    break;
                default:
                    return Estimate;
                    break;
            }
        }
    }
}