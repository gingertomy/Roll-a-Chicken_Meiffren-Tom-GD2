using UnityEngine;
using UnityEngine.UI;

public class Axe : MonoBehaviour
{
    [SerializeField] private GameObject _axeImage;
    [SerializeField] private AudioClip _collectSound;
    public static bool _axeEquipped = false;

    void Start()
    {
        _axeEquipped = false;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
            AudioSource.PlayClipAtPoint(_collectSound, transform.position);
            Destroy(gameObject);
            _axeImage.SetActive(true);
            _axeEquipped = true;
        }
    }
}

