using UnityEngine;

public class WateringCan : MonoBehaviour
{
    [SerializeField] private GameObject _wateringCanImage;
    [SerializeField] private AudioClip _collectSound;
    public static bool _wateringCanEquipped = false;

    void Start()
    {
        _wateringCanEquipped = false;
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
            AudioSource.PlayClipAtPoint(_collectSound, transform.position);
            Destroy(gameObject);
            _wateringCanImage.SetActive(true);
            _wateringCanEquipped = true;
        }
    }
}
