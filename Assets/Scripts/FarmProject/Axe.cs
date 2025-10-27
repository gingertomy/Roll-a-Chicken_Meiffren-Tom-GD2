using UnityEngine;
using UnityEngine.UI;

public class Axe : MonoBehaviour
{
    [SerializeField] private GameObject _axeImage;
    public static bool _axeEquipped = false;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
            Destroy(gameObject);
            _axeImage.SetActive(true);
            _axeEquipped = true;
        }
    }
}

