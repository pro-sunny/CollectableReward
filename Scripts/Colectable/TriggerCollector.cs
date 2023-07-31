using UnityEngine;

public class TriggerCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<ICollectable>(out var collectable))
        {
            collectable.Activate();
        }
    }
}
