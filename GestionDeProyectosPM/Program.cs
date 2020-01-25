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
            task.Estimate = 10;
            task.Difficulty = Difficulty.easy;

            var task1 = new TaskComplicated();
            task1.UserStory = userStory1;
            task1.Estimate = 10;
            task1.Difficulty = Difficulty.compliacted;

            var task2 = new TaskSuperComplicated();
            task2.UserStory = userStory2;
            task2.Estimate = 10;
            task2.Difficulty = Difficulty.superComplicated;

            var sprintBacklog = new SprintBacklog();
            sprintBacklog.addTask(task);
            sprintBacklog.addTask(task1);

            var sprintBacklog1 = new SprintBacklog();
            sprintBacklog1.addTask(task2);

            var project = new Project();
            project.addSprintBacklog(sprintBacklog);
            project.addSprintBacklog(sprintBacklog1);
            Console.WriteLine("Horas de la tarea: " + task.getHours().ToString());
            Console.WriteLine("Horas de la tarea: " + task1.getHours().ToString());
            Console.WriteLine("Horas de la tarea: " + task2.getHours().ToString());
            Console.WriteLine("Horas del backlog: " + sprintBacklog.getHours().ToString());
            Console.WriteLine("Horas del backlog: " + sprintBacklog1.getHours().ToString());
            Console.WriteLine("Horas del project: " + project.getHours().ToString());
        }
    }
}
