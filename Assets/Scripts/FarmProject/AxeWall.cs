using UnityEngine;

public class AxeWall : MonoBehaviour
{
    [SerializeField] private Axe _Axe;
    [SerializeField] private AudioClip _complete;
    [SerializeField] private AudioClip _fail;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
                if (Axe._axeEquipped)
                {
                    AudioSource.PlayClipAtPoint(_complete, transform.position);
                    Destroy(gameObject);
                }
                else
                {
                    AudioSource.PlayClipAtPoint(_fail, transform.position, 2.5f);
                }
        }
        
    }
}

        
    
    

