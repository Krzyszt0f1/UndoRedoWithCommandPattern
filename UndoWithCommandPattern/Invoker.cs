namespace UndoWithCommandPattern;

// Invoker manages the Undo Redo stacks and executes any commands passed in
public class Invoker
{
    private Stack<ICommand> _undoStack = new();
    private Stack<ICommand> _redoStack = new();

    public void Execute(ICommand command)
    {
        _redoStack.Clear();
        command.Execute();
        _undoStack.Push(command);
    }

    public void Undo()
    {
        if (_undoStack.Count > 0)
        {
            _undoStack.Peek().Undo();
            _redoStack.Push(_undoStack.Pop());
        }
    }

    public void Redo()
    {
        if (_redoStack.Count > 0)
        {
            _redoStack.Peek().Redo();
            _undoStack.Push(_redoStack.Pop());
        }
    }
}