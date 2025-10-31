using System.Collections;
using UnityEngine;

public class FlowerField : MonoBehaviour
{
    [SerializeField] private WateringCan _wateringCan;
    [SerializeField] private Fertilizer _fertilizer;
    [SerializeField] private GameObject _flowersPrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private PlayerMovement _playerMovement;
    private bool _isBoosted = false;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
            Instantiate(_flowersPrefab,
                _spawnPoint.position + Vector3.up * 0.5f, _spawnPoint.rotation);
            if (!_isBoosted)
            {
                StartCoroutine(SpeedBoost());
            }
        }
    }

    private IEnumerator SpeedBoost()
    {
        _isBoosted = true;
        _playerMovement._speed *= 2f;
        yield return new WaitForSeconds(5f); 
        _isBoosted = false;
    }
}
    
