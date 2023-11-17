abstract class CommandUser
{
    public abstract void Execute();
    
}

public interface IUndoCommand
{
    void Undo();
}
