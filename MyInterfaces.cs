public interface IFlyable
{
    void Fly();
    int MaximumHeight { get; }
}


public interface IMovable
{
    void Move();
}

public interface IDriveable : IMovable
{
    void StartEngine();
}

