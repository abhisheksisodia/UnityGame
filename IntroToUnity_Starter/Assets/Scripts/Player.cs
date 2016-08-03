using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 5;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Move(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Move(Vector3.back);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Move(Vector3.left);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Move(Vector3.right);
        }
    }

    private void Move(Vector3 direction)
    {
        _rigidbody.AddForce(direction * MoveSpeed);
    }
}
