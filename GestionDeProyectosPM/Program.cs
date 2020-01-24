using System;

namespace GestionDeProyectosPM
{
    class Program
    {
        static void Main(string[] args)
        {
            UserStory userStory;
            userStory.how = "Cliente";
            userStory.want = "Dar de alta clientes";
            userStory.to = "Venderles cosas";

            var task = new Task();
            task.UserStory = userStory;
            task.Estimate = 1;
            task.Difficulty = Difficulty.compliacted;

            var sprintbBacklog = new SprintBacklog();
            sprintbBacklog.addTask(task);

            var project = new Project();
            project.addSprintBacklog(sprintbBacklog);
            Console.WriteLine("Horas de la tarea: " + task.getHours().ToString());
            Console.WriteLine("Horas del backlog: " + sprintbBacklog.getHours().ToString());
            Console.WriteLine("Horas del project: " + project.getHours().ToString());
        }
    }
}
