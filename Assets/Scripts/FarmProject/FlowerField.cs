using UnityEngine;

public class FlowerField : MonoBehaviour
{
    [SerializeField] private WateringCan _wateringCan;
    [SerializeField] private Fertilizer _fertilizer;
    [SerializeField] private GameObject _flowersPrefab;
    [SerializeField] private Transform _spawnPoint;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
                    Instantiate(_flowersPrefab,
                        _spawnPoint.position + Vector3.up * 0.5f, _spawnPoint.rotation);
                    _fertilizer.UsedFertilizer();
                    Destroy(gameObject);
        }
    } 
}
    
