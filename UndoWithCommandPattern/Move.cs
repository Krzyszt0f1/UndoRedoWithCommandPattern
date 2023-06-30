namespace UndoWithCommandPattern;

// Move is a command that implements execution,
// undoing and redoing of a Receiver.
// Receiver is a Point class in this example.
public class Move : ICommand
{
    private Point _point;
    private Position _newPosition;
    private Position _oldPosition;

    public Move(Point point, Position position)
    {
        _point = point;
        _newPosition = position;
    }

    public void Execute()
    {
        _oldPosition = _point.GetPosition();
        _point.SetPosition(_newPosition);
    }

    public void Undo()
    {
        // preventing running out of stack
        // if client would be to undo before any execution
        if (_oldPosition != null)
        {
            _point.SetPosition(_oldPosition);
        }
    }

    public void Redo()
    {
        _point.SetPosition(_newPosition);
    }
}