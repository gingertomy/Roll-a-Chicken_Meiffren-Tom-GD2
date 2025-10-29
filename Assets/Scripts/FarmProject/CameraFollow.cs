using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _rotationSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.position = _player.transform.position;  
        
        /*if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, -_rotationSpeed * Time.deltaTime);
        }*/

    }
}
