public abstract class Reward : IReward
{
    public abstract void GiveReward();
}

public abstract class Reward<T> : IReward where T : IRewardData
{
    protected abstract T Data { get; }
    
    public abstract void GiveReward();
}