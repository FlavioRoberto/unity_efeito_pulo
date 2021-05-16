using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidBody;
    public float Velocidade = 10;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidBody.velocity = Vector3.right * Velocidade * Time.deltaTime;
        }
    }
}
