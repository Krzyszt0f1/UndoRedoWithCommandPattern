using UndoWithCommandPattern;

// Initialising the invoker
var invoker = new Invoker();

// A point to be manipulated
var pointToMoveAround = new Point();

// A starting position of a point
var initialPosition = new Position()
{
    X = 0,
    Y = 0
};

// Series of initialisations and executions of commands via the invoker 
var moveToPoint0And0 = new Move(pointToMoveAround, initialPosition);
invoker.Execute(moveToPoint0And0);
Console.WriteLine($"Moved the point to: ({pointToMoveAround.GetPosition().X}, {pointToMoveAround.GetPosition().Y})");

var northEastPosition  = new Position()
{
  X = 7,
  Y = 4
};

var moveToPoint7And4 = new Move(pointToMoveAround, northEastPosition);
invoker.Execute(moveToPoint7And4);
Console.WriteLine($"Moved the point to: ({pointToMoveAround.GetPosition().X}, {pointToMoveAround.GetPosition().Y})");

var southWestPosition  = new Position()
{
    X = -3,
    Y = -2
};

var moveToPointMinus3AndMinus2 = new Move(pointToMoveAround, southWestPosition);
invoker.Execute(moveToPointMinus3AndMinus2);
Console.WriteLine($"Moved the point to: ({pointToMoveAround.GetPosition().X}, {pointToMoveAround.GetPosition().Y})");


// Running a series of undos and redos
Console.WriteLine("Undoing...");
invoker.Undo();
Console.WriteLine($"The point is now at: ({pointToMoveAround.GetPosition().X}, {pointToMoveAround.GetPosition().Y})");

Console.WriteLine("Undoing...");
invoker.Undo();
Console.WriteLine($"The point is now at: ({pointToMoveAround.GetPosition().X}, {pointToMoveAround.GetPosition().Y})");

Console.WriteLine("Redoing...");
invoker.Redo();
Console.WriteLine($"The point is now at: ({pointToMoveAround.GetPosition().X}, {pointToMoveAround.GetPosition().Y})");

Console.WriteLine("Redoing...");
invoker.Redo();
Console.WriteLine($"The point is now at: ({pointToMoveAround.GetPosition().X}, {pointToMoveAround.GetPosition().Y})");
