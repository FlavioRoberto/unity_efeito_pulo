using UnityEngine;
using Enums;

public class Player : MonoBehaviour
{
    public float Velocity;
    public float JumpForce;
    private Rigidbody _rigidBody;
    private bool _inFloor;

    public Player()
    {
        Velocity = 10;
        JumpForce = 10;
    }

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void OnCollisionEnter(Collision collision)
    {
        VerifyInFloor(collision);
    }

    private void VerifyInFloor(Collision collision)
    {
        if (collision.gameObject.layer == (int)ELayer.FLOOR)
            _inFloor = true;
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidBody.AddForce(Vector3.right * Velocity * Time.deltaTime, ForceMode.Acceleration);
        }
    }

    private void Jump()
    {
        var canJump = Input.GetKeyDown(KeyCode.Space) && _inFloor;

        if (canJump)
        {
            _inFloor = false;
            _rigidBody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }
}
