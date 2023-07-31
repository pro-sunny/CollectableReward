using UnityEngine;
using Zenject;

//example class
public class Crate : MonoBehaviour
{
    [Inject] private IBulletsGiver _bulletsGiver;
    
    [Inject] private ICollectablesDataHolder _collectableDataHolder;
    
    public void OnCrateDestroyed()
    {
        var data = new BulletsRewardData()
        {
            Bullets = 15
        };
        var reward = new BulletsReward<BulletsRewardData>(_bulletsGiver, data);
        
        CollectableMagazine magazinePrefab = _collectableDataHolder.GetMagazinePrefab();
        CollectableMagazine item = Instantiate(magazinePrefab, transform.position, Quaternion.identity, transform);
        item.Initialize(reward);
    }
}