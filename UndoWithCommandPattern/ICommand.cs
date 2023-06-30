namespace UndoWithCommandPattern;

// The Command interface declares a methods for executing, undoing and redoing
// a command.
public interface ICommand
{
    void Execute();
    void Undo();
    void Redo();
}