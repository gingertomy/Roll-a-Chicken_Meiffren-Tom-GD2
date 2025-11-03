using UnityEngine;

public class PlantSlot : MonoBehaviour
{
    [SerializeField] private WateringCan _wateringCan;
    [SerializeField] private Fertilizer _fertilizer;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private ScoreDatas _scoreData;
    [SerializeField] private AudioClip _complete;
    [SerializeField] private AudioClip _fail;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
            if (WateringCan._wateringCanEquipped)
            {
                AudioSource.PlayClipAtPoint(_fail, transform.position, 2.5f);
                if (_scoreData.Inventory > 0)
                {
                    Instantiate(_plantPrefab,
                        _spawnPoint.position + Vector3.up * 0.9f, _spawnPoint.rotation);
                    _fertilizer.UsedFertilizer();
                    AudioSource.PlayClipAtPoint(_complete, transform.position);
                    Destroy(gameObject);
                    
                }
            }
            else
            {
                AudioSource.PlayClipAtPoint(_fail, transform.position, 2.5f);
            }
        }
    }
    
}

