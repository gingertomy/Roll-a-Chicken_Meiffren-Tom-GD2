using UnityEngine;

public class ParticuleController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Durée de vie, invoke appelle des fonctions au bout d'un certain temps
        Destroy(gameObject,5f);
    }
}
