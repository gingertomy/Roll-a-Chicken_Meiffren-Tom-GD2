using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    private float _horizontalMovement;
    private float _verticalMovement;
    private Vector3 _movement;
    private Vector3 _grappinDirection;
    private Vector3 _grappinHit;
    [SerializeField] private float _speed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement = Input.GetAxis("Horizontal");
        _verticalMovement = Input.GetAxis("Vertical");
        _movement = new Vector3(_horizontalMovement, 0.0f, _verticalMovement);
        GrappinUpdateDirection(_movement); //mise a jour de la direction du tir du grappin
        _movement.Normalize();
        _movement *= _speed;
        _movement.y = _rb.linearVelocity.y;
        if (_rb != null)
        {
            _rb.linearVelocity = _movement;
        }
        else
        {
            Debug.LogError("No RigidBody found");
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            TryThrowGrappin();
        }

        if (Input.GetKeyUp(KeyCode.G))
        {
            ThrowGrappin();
        }
    }

    private void GrappinUpdateDirection(Vector3 direction)
        {
            if (direction.sqrMagnitude > 0.1f)
            {
                _grappinDirection = direction;
            }
        }

        private void TryThrowGrappin()
        {
            RaycastHit Hit;
            if (Physics.Raycast(transform.position,
                    _grappinDirection, out Hit, 100f))
            {
                Debug.DrawRay(transform.position, transform.position+_grappinDirection*100f, Color.red);
                _grappinHit = Hit.point + Hit.normal * 1.5f;
            }
        }

        private void ThrowGrappin()
        {
        transform.position = _grappinHit;
        _grappinDirection = Vector3.zero;
        }
    }


