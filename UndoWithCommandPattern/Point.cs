namespace UndoWithCommandPattern;

// Point acts here as a Receiver, it receives actions dispatched by Move class
public class Point
{
    private Position _position;

    public void SetPosition(Position position)
    {
        _position = position;
    }

    public Position GetPosition()
    {
        return _position;
    }
}