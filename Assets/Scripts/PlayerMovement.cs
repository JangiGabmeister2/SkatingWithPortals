using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] private float _moveSpeed = 5f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(vertical, 0, -horizontal);

        rb.AddTorque(movement * _moveSpeed);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            while (rb.velocity.magnitude > 0)
            {
                rb.velocity -= new Vector3(0, 0, 0) * Time.deltaTime;
            }
        }
    }
}
