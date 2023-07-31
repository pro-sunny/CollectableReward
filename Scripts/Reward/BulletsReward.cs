using Zenject;


// example class
public class BulletsReward : Reward
{
    private int _gunId;
    private int _bullets;
    private readonly IBulletsGiver _bulletsGiver;

    [Inject]
    public BulletsReward(int gunId, int bullets, IBulletsGiver bulletsGiver)
    {
        _gunId = gunId;
        _bullets = bullets;
        _bulletsGiver = bulletsGiver;
    }
    
    public override void GiveReward()
    {
        _bulletsGiver.AddBullets(_bullets);
    }
}

// example class
public class BulletsReward<T> : Reward<T> where T : BulletsRewardData
{
    private readonly IBulletsGiver _bulletsGiver;

    protected override T Data { get; }
    
    public BulletsReward(T data, IBulletsGiver bulletsGiver)
    {
		Data = data;
		_bulletsGiver = bulletsGiver;
    }

    public override void GiveReward()
    {
        _bulletsGiver.AddBullets(Data.Bullets);
    }
}

public class BulletsRewardData : IRewardData
{
    public int Bullets;
}