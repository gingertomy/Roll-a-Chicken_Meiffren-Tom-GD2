using UnityEngine;

public class AxeWall : MonoBehaviour
{
    [SerializeField] private Axe _Axe;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
                if (Axe._axeEquipped)
                {
                    Destroy(gameObject);
                }
        }
    }
}

        
    
    

