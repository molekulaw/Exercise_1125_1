using ConsoleApp5.Commands;

class CommandManager
{
    Dictionary<string, (Type type, object[] args)> commands = new();
    public void Start()
    {
        string command;
        do
        {
            Console.WriteLine("Введите команду");
            command = Console.ReadLine();
            TestCommand(command);
        }
        while (command != "exit");
    }
    
    Stack<IUndoCommand> historyCommands = new Stack<IUndoCommand>();

    void TestCommand(string? command)
    {
        if (commands.ContainsKey(command))
        {
            Type typeCommand = commands[command].type;
            var commandInstance = (CommandUser)Activator.CreateInstance(typeCommand, commands[command].args);
            commandInstance.Execute();
            if (commandInstance is IUndoCommand iCommand)
                historyCommands.Push(iCommand);            
        }
    }

    public void UndoLastCommand()
    {
        if (historyCommands.Count == 0)
            return;
        IUndoCommand lastCommand = historyCommands.Pop();
        lastCommand.Undo();
    }

    public void RegisterCommand(string command, Type commandStudent, params object[] args)
    {
        commands.Add(command, (commandStudent, args));
    }
}
