using System;

namespace GestionDeProyectosPM
{
    class Program
    {
        static void Main(string[] args)
        {
            UserStory userStory, userStory1, userStory2;
            userStory.how = "PM";
            userStory.want = "Poder saber la duracion de cada tarea";
            userStory.to = "Poder tener un control de cada una.";

            userStory1.how = "PM";
            userStory1.want = "Poder saber la duracion de cada Sprint";
            userStory1.to = "Poder tener un control de cada uno.";

            userStory2.how = "PM";
            userStory2.want = "Poder saber la duracion de cada Proyecto";
            userStory2.to = "Poder tener un control de cada uno.";

            var task = new TaskEasy();
            task.UserStory = userStory;
            task.Estimate = 5;
            task.Difficulty = Difficulty.easy;

            var task1 = new TaskComplicated();
            task1.UserStory = userStory1;
            task1.Estimate = 5;
            task1.Difficulty = Difficulty.complicated;

            var task2 = new TaskSuperComplicated();
            task2.UserStory = userStory2;
            task2.Estimate = 5;
            task2.Difficulty = Difficulty.superComplicated;

            var sprintBacklog = new SprintBacklog();
            sprintBacklog.addTask(task);
            sprintBacklog.addTask(task1);

            var sprintBacklog1 = new SprintBacklog();
            sprintBacklog1.addTask(task2);

            var project = new Project();
            project.addSprintBacklog(sprintBacklog);
            project.addSprintBacklog(sprintBacklog1);
            
            Console.WriteLine("Cantidad de horas del Proyecto: " + project.getHours().ToString());
            foreach (var _sprint in project.getAllSprintsBacklogs())
            {
                Console.WriteLine("\nCantidad de horas en este sprint: " + _sprint.getHours());
                foreach (var _task in _sprint.getAllTasks())
                {
                    Console.WriteLine("Tarea");
                    Console.WriteLine("Dificultad: " + _task.Difficulty.ToString());
                    Console.WriteLine("Estimacion: " + _task.Estimate.ToString());
                    Console.WriteLine("Horas: " + _task.getHours().ToString());
                    Console.WriteLine("User Story");
                    Console.WriteLine("How: " + _task.UserStory.how);
                    Console.WriteLine("Want: " + _task.UserStory.want);
                    Console.WriteLine("To: " + _task.UserStory.to + "\n");
                }
            }

            Console.ReadKey();
        }
    }
}
