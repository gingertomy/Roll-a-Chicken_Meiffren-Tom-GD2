using System.Collections;
using UnityEngine;

public class FlowerField : MonoBehaviour
{
    [SerializeField] private WateringCan _wateringCan;
    [SerializeField] private Fertilizer _fertilizer;
    [SerializeField] private GameObject _flowersPrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private AudioClip _complete;
    [SerializeField] private AudioClip _fail;
    private bool _isBoosted = false;
    private bool _hasUsedBoost = false;
    

    private void OnCollisionEnter(Collision other)
    {
            if (other.gameObject.GetComponent<Collector>() != null)
            {
                if (WateringCan._wateringCanEquipped)
                {
                    Instantiate(_flowersPrefab,
                        _spawnPoint.position, _spawnPoint.rotation);
                    AudioSource.PlayClipAtPoint(_complete, transform.position);
                    if (!_isBoosted && !_hasUsedBoost)
                    {
                        StartCoroutine(SpeedBoost());
                        _hasUsedBoost = true;
                    }
                    GetComponent<Collider>().enabled = false;
                }
                else
                {
                    AudioSource.PlayClipAtPoint(_fail, transform.position);
                }
            }
    }

    private IEnumerator SpeedBoost()
    {
        _isBoosted = true;
        float originalSpeed =_playerMovement._speed;
        _playerMovement._speed *= 2f;
        yield return new WaitForSeconds(5f);
        _playerMovement._speed = originalSpeed;
        _isBoosted = false;
    }
}
    
