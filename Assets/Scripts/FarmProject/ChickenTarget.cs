using UnityEngine;

public class ChickenTarget : MonoBehaviour
{    
    [SerializeField] private int _targetValue = 1;
    [SerializeField] private AudioClip _collectChickenSound;
    private bool _collected = false;
    private void OnCollisionEnter(Collision other)
    {
            if (other.gameObject.GetComponent<Collector>() != null)
            {
                if (!_collected)
                {
                    _collected = true;
                    other.gameObject.GetComponent<Collector>().UpdateScore(_targetValue);
                    AudioSource.PlayClipAtPoint(_collectChickenSound, transform.position);
                    Destroy(gameObject);
                }
            }
        }
    }


