using ConsoleApp5.Commands;
using System.Xml.Linq;

class Program
{
    public static void Main()
    { 
        CommandManager commandManager = new CommandManager();
        StudentDB studentDB = new StudentDB();
        commandManager.RegisterCommand("Create", typeof(CommandCreateStudent), studentDB);
        commandManager.RegisterCommand("List", typeof(CommandListStudents), studentDB);
        commandManager.RegisterCommand("Undo", typeof(CommandUndo), commandManager);
        // добавить команды:
        // Search - поиск студентов по имени/фамилии, должен выводиться UID
        // Delete - удаление выбранного студента (по UID или порядковому номеру в выведенном списке)
        // Edit - редактирование выбранного студента
        commandManager.Start();
    }

}
