using UnityEngine;

public class PlantSlot : MonoBehaviour
{
    [SerializeField] private WateringCan _wateringCan;
    [SerializeField] private Fertilizer _fertilizer;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private ScoreDatas _scoreData;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
            if (WateringCan._wateringCanEquipped)
            {
                Debug.Log("laacaca");
                if (_scoreData.Inventory >= 0)
                {
                    Instantiate(_plantPrefab,
                        _spawnPoint.position + Vector3.up * 1f, _spawnPoint.rotation);
                    _fertilizer.UsedFertilizer();
                    Destroy(gameObject);
                    
                }

                
            }
        }
    }
    
}

