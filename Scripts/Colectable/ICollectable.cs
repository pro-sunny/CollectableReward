public interface ICollectable
{
    public void Activate();
}

public interface ICollectable<T> : ICollectable where T : IReward
{
    public void Initialize(T data);
}