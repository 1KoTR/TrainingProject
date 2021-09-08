using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float AngularSpeed;

    [SerializeField] private Vector3 Direction;

    private Rigidbody _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        _rigidBody.AddForce(transform.forward * Input.GetAxis("Vertical") * MoveSpeed);
    }

    private void Rotate()
    {
        transform.localEulerAngles += new Vector3(0, Input.GetAxis("Horizontal") * AngularSpeed, 0);
    }
}
