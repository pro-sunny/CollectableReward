using UnityEngine;

public abstract class CollectableItem : MonoBehaviour, ICollectable<IReward>
{
	[SerializeField] private bool _destroyAfterActivation;
	
    private IReward _reward;

    public void Initialize(IReward reward)
    {
        _reward = reward;
    }
    
    public void Activate()
    {
        _reward.GiveReward();
        if (_destroyAfterActivation)
        {
            Destroy(gameObject);
        }
    }
}