using System;
using System.Collections.Generic;

namespace GestionDeProyectosPM
{
    public class Task
    {
        //Campos
        private int _estimate;

        
        //Constructores
        public Task()
        {
            _estimate = 0;
        }


        //Propiedadades
        public int Estimate
        {
            get {
                return _estimate;
            }
            set {
                
                _estimate = checkFibonacci(value);
            }
        }

        //public int Estimate { get; set; }

        public UserStory UserStory { get; set; }

        public Difficulty Difficulty { get; set; }


        //Metodos
        public virtual float getHours()
        {
            return 0;
        }

        private int checkFibonacci(int value)
        {
            if (!this.getSerieFibonacci().Exists(item => item == value) )
            {
                throw new System.ArgumentException("Debe ser un numero perteciente a la serie de Fibonacci", "Estimacíon");
            }
            return value;
        }
        private List<int> getSerieFibonacci()
        {
            List<int> _serie = new List<int>(new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 });
            return _serie;
        }
        /*
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
        */
    }
}