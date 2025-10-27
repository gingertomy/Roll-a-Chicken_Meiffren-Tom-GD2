using UnityEngine;

public class WateringCan : MonoBehaviour
{
    [SerializeField] private GameObject _wateringCanImage;
    public static bool _wateringCanEquipped = false;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
            Destroy(gameObject);
            _wateringCanImage.SetActive(true);
            _wateringCanEquipped = true;
        }
    }
}
