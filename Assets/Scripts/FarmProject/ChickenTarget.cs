using UnityEngine;

public class ChickenTarget : MonoBehaviour
{    
    [SerializeField] private int _targetValue = 1;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
            other.gameObject.GetComponent<Collector>().UpdateScore(_targetValue);
            Destroy(gameObject);
        }
    }
}

